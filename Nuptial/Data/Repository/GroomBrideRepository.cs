using Nuptial.Models.Data;

namespace Nuptial.Data.Repository
{
    public class GroomBrideRepository : EntityBaseRepository<GroomBride>
    {
        public GroomBrideRepository(Context context) : base(context) { }
    }
}