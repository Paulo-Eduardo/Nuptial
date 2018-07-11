using Nuptial.Data;
using System;
using System.Web;

namespace Nuptial.Models.Data
{
    public class Footer : IEntityBase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Dribbble { get; set; }
        public string Youtube { get; set; }
        public string CopyrightText { get; set; }
        public DateTime Updated { get; set; }
    }
}