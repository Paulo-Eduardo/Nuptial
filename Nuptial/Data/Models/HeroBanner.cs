using Nuptial.Data;
using Nuptial.Data.Models;
using System;

namespace Nuptial.Models.Data
{
    public class HeroBanner : IEntityBase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public bool ShowDate { get; set; }
        public EnumPage Page { get; set; }
        public DateTime Updated { get; set; }
    }
}