using Microsoft.AspNetCore.Identity;

namespace HotelListing_APi.Data
{
    public class ApiUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
