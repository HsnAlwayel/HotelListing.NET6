using Microsoft.Build.Framework;

namespace HotelListing_APi.Models.Country
{
    public abstract class BaseCountryDto
    {
        
        public string Name { get; set; }
        public string ShortName { get; set; }

    }
}
