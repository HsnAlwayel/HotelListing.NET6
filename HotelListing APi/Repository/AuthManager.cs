using AutoMapper;
using HotelListing_APi.Contracts;
using HotelListing_APi.Data;
using HotelListing_APi.Models;
using HotelListing_APi.Models.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace HotelListing_APi.Repository
{
    public class AuthManager : IAuthManager
    {
        private readonly IMapper _mapper;
        private readonly UserManager<ApiUser> _userManager;
        private readonly IConfiguration _configuration;

        public AuthManager(IMapper mapper,UserManager<ApiUser> userManager,IConfiguration configuration)
        {
            this._mapper = mapper;
            this._userManager = userManager;
            this._configuration = configuration;
        }

        public UserManager<ApiUser> UserManager { get; }

        public async Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto)
        {
            var user=_mapper.Map<ApiUser>(userDto);
            user.UserName = userDto.Email;
            
            var result=await _userManager.CreateAsync(user,userDto.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "User");
            }

            return result.Errors;

        }

        public async Task<AuthResponseDto> Login(LoginDto loginDto)
        {
        //this checks if the user exist
        var user = await _userManager.FindByEmailAsync(loginDto.Email);
        //checks password after fetching user and validate
        bool isValidUser = await _userManager.CheckPasswordAsync(user, loginDto.Password);



            if (user == null||isValidUser==false)
            {
                return null;
            };

            var token = await GenerateToken(user);

            return new AuthResponseDto
            {
                Token = token,
                UserId = user.Id
            };

        }

        private async Task<string> GenerateToken(ApiUser user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:Key"]));

            var credentials =new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha256);

            var roles=await _userManager.GetRolesAsync(user);

            var roleClaims = roles.Select(x => new Claim(ClaimTypes.Role, x)).ToList();

            var userClaims=await _userManager.GetClaimsAsync(user);

            var claims=new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub,user.Email),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email,user.Email),
                new Claim("uid",user.Email),
            }.Union(userClaims).Union(roleClaims);

            var token = new JwtSecurityToken(
                issuer: _configuration["JwtSettings:Issuer"],
                audience: _configuration["JwtSettings:Audience"],
                claims:claims,
                expires: DateTime.Now.AddMinutes(Convert.ToInt32(_configuration["JwtSettings:DurationInMinutes"])),
                signingCredentials:credentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
