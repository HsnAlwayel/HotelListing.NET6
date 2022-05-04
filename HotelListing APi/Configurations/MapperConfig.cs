using AutoMapper;
using HotelListing_APi.Data;
using HotelListing_APi.Models.Country;
using HotelListing_APi.Models.Hotel;

namespace HotelListing_APi.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDetailsDto>().ReverseMap();
            CreateMap<Hotel, GetHotelDto>().ReverseMap();
        }
    }
}
