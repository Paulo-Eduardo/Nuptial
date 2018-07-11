using System;

namespace Nuptial.Models
{
    public class CoupleModel
    {
        public PersonModel Groom { get; set; }
        public PersonModel Bride { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}