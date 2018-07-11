using Nuptial.Data;
using Nuptial.Services;

namespace Nuptial.Models
{
    public class GroomModel
    {
        Context context = new Context();
        public PersonModel groom { get; set; }
        PersonService service;

        private GroomModel()
        {
            service = new PersonService(new Nuptial.Data.Repository.PersonRepository(context));
            groom = service.GetPerson(Data.EnumGroomBride.Groom);
        }

        public static GroomModel Instance { get { return Nested.instance; } }

        private class Nested
        {
            static Nested()
            {

            }

            internal static readonly GroomModel instance = new GroomModel();
        }
    }
}

