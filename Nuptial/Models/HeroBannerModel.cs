using Nuptial.Data.Models;

namespace Nuptial.Models
{
    public class HeroBannerModel
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public bool ShowDate { get; set; }
        public EnumPage Page { get; set; }
    }
}