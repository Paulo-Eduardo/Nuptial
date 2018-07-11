using Nuptial.Data;
using System;

namespace Nuptial.Models.Data
{
    public class Couple : IEntityBase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime Updated { get; set; }
    }
}