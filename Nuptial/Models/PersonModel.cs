using Nuptial.Models.Data;

namespace Nuptial.Models
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Biography { get; set; }
        public string Picture { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Dribbble { get; set; }
        public string Youtube { get; set; }
        public EnumGroomBride GoomBride { get; set; }
    }
}