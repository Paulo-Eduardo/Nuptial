using Nuptial.Models.Data;
using System.Data.Entity;

namespace Nuptial.Data
{
    public class Context : DbContext
    {
        DbSet<Person> Pessoa { get; set; }
        DbSet<Footer> Footer { get; set; }
        DbSet<Couple> Couple { get; set; }
        DbSet<GroomBride> GroomBride { get; set; }
        DbSet<HeroBanner> HeroBanner { get; set; }
    }
}