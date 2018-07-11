using Nuptial.Models.Data;

namespace Nuptial.Data.Repository
{
    public class PersonRepository : EntityBaseRepository<Person>
    {
        public PersonRepository(Context context) : base(context) { }
    }
}