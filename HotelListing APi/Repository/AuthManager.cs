using AutoMapper;
using HotelListing_APi.Contracts;
using HotelListing_APi.Data;
using HotelListing_APi.Models;
using Microsoft.AspNetCore.Identity;

namespace HotelListing_APi.Repository
{
    public class AuthManager : IAuthManager
    {
        private readonly IMapper _mapper;
        private readonly UserManager<ApiUser> _userManager;
        public AuthManager(IMapper mapper,UserManager<ApiUser> userManager)
        {
            this._mapper = mapper;
            this._userManager = userManager;
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
    }
}
