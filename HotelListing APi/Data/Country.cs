namespace HotelListing_APi.Data
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        //Declare relation between hotel and count, Each hotel have one country, Country have multiple hotels (One to many)
        public virtual IList<Hotel> Hotels { get; set; }
    }
}
