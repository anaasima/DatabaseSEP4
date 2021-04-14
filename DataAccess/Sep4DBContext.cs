using Microsoft.EntityFrameworkCore;

namespace DatabaseSEP4
{
    public class Sep4DBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}