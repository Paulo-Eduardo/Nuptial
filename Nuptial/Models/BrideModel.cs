using Nuptial.Data;
using Nuptial.Services;

namespace Nuptial.Models
{
    public sealed class BrideModel
    {
        Context context = new Context();
        public PersonModel bride{ get; set; }
        PersonService service;

        private BrideModel()
        {
            service = new PersonService(new Nuptial.Data.Repository.PersonRepository(context));
            bride = service.GetPerson(Data.EnumGroomBride.Bride);
        }

        public static BrideModel Instance { get { return Nested.instance;  } }

        private class Nested
        {
            static Nested()
            {

            }

            internal static readonly BrideModel instance = new BrideModel();
        }
    }
}