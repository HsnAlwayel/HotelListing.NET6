using HotelListing_APi.Data;
using HotelListing_APi.Contracts;

namespace HotelListing_APi.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        private readonly HotelListingDbContext context;

        public HotelsRepository(HotelListingDbContext context) : base(context)
        {
            this.context = context;
        }
    }
}
