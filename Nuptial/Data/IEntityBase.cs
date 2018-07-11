using System;

namespace Nuptial.Data
{
    public interface IEntityBase
    {
        int Id { get; set; }
        DateTime Updated { get; set; } 
    }
}