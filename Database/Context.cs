using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Database.Context 
{
    public class MovieContext : DbContext 
    {        
        public override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql("Host=localhost;Database=Streaminator;Username=localhost;Password=1234");
    }
}