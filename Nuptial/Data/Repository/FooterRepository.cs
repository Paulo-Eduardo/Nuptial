using Nuptial.Models.Data;

namespace Nuptial.Data.Repository
{
    public class FooterRepository : EntityBaseRepository<Footer>
    {
        public FooterRepository(Context context) : base(context) { }
    }
}