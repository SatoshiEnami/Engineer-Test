using System.Data.Entity;

namespace EngineerTest.Models
{
    public class MvcBasicContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
    }
}
