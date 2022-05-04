namespace HotelListing_APi.Models.Hotel;

public class GetHotelDto
{
    public int Id { get; set; }        //Id is the primary Key
    public string Name { get; set; }
    public string Address { get; set; }
    public double Rating { get; set; }
    public int CountryId { get; set; }
}