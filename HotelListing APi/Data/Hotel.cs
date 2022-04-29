using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing_APi.Data
{
    public class Hotel
    {
        //Table proporties declerations
        public int Id { get; set; }        //Id is the primary Key
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }

        //Foreign Key
        [ForeignKey(nameof(CountryId))]    //This is how we choose foreign Key for table
        public int CountryId { get; set; }

        //
        public Country Country { get; set; }
    }
}