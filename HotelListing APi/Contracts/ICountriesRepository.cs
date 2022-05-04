using HotelListing_APi.Data;

namespace HotelListing_APi.Contracts;

public interface ICountriesRepository : IGenericRepository<Country>
{
    Task<Country> GetDetails(int id);
}