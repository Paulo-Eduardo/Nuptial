using System;
using Nuptial.Data;

namespace Nuptial.Models.Data
{
    public class Person : IEntityBase
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Biography { get; set; }
        public string Picture { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Dribbble { get; set; }
        public string Youtube { get; set; }
        public EnumGroomBride GroomBride { get; set; }
        public DateTime Updated { get; set; }
    }
}