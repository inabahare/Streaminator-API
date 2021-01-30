using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Models.Database;

namespace Database.Context
{
    public class MovieContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
        public DbSet<WatchStatus> WatchStatuses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql("Host=localhost;Database=Streaminator;Username=postgres;Password=1234");
    }
}