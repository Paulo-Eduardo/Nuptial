namespace Nuptial.Models
{
    public class GroomBrideModel
    {
        public string Title { get; set; }
        public PersonModel Groom { get; set; }
        public PersonModel Bride { get; set; }
    }
}