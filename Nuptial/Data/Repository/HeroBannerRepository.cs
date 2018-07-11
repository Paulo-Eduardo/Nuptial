using Nuptial.Models.Data;

namespace Nuptial.Data.Repository
{
    public class HeroBannerRepository : EntityBaseRepository<HeroBanner>
    {
        public HeroBannerRepository(Context context) : base(context) { }
    }
}