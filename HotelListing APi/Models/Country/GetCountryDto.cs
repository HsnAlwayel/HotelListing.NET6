

using HotelListing_APi.Models.Hotel;

namespace HotelListing_APi.Models.Country
{
    public class GetCountryDto :BaseCountryDto
    {
        public int Id { get; set; }
       

    }
    public class GetCountryDetailsDto : BaseCountryDto
    {
        public int Id { get; set; }
        

        public List<GetHotelDto> Hotels { get; set; }

    }
}
