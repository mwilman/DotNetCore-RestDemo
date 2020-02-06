using System.Collections.Generic;
using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Game> Games { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasData(
                new Game()
                {
                    ID = 1,
                    Name = "Tetris",
                },
                new Game()
                {
                    ID = 2,
                    Name = "Mario",
                }
            );
            
            base.OnModelCreating(modelBuilder);
        }
    }
}