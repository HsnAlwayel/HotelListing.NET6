using HotelListing_APi.Models;
using Microsoft.AspNetCore.Identity;

namespace HotelListing_APi.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto);
    }
}
