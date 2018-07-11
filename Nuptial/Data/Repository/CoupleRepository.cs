using Nuptial.Models.Data;

namespace Nuptial.Data.Repository
{
    public class CoupleRepository : EntityBaseRepository<Couple>
    {
        public CoupleRepository(Context context) : base(context) { }
    }
}