using HotelListing_APi.Models.Users;
using Microsoft.AspNetCore.Identity;

namespace HotelListing_APi.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto);

        Task<AuthResponseDto> Login(LoginDto userDto);
    }
}
