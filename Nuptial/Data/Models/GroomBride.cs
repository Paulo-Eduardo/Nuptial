using Nuptial.Data;
using System;

namespace Nuptial.Models.Data
{
    public class GroomBride : IEntityBase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Updated { get; set; }
    }
}