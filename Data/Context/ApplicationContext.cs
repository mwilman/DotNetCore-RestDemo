using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Game> Games { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(local);Initial Catalog=MyDb;Integrated Security=True;User Id=sa;Password=MyPass@word; Trusted_Connection=False");
        }
    }
}