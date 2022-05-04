

using System.ComponentModel.DataAnnotations;

namespace HotelListing_APi.Models.Hotel;

public class GetHotelDto :BaseHotelDto
{
    public int Id { get; set; }        //Id is the primary Key

}

public class GetHotelDetailsDto : BaseHotelDto
{
    public int Id { get; set; } 
}