using Microsoft.EntityFrameworkCore;
using WebApplication2.Model;

namespace WebApplication2
{
    public class AppDBContext : DbContext
    {
        public DbSet<User> UsersTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("db1");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
