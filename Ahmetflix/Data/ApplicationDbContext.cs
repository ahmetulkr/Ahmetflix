using Ahmetflix.Models;
using Microsoft.EntityFrameworkCore;

namespace Ahmetflix.Data
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

         
       public DbSet<Movie> Movies { get; set; }
       public DbSet<Series> Series { get; set; }
       public DbSet<AppUser> AppUsers { get; set; }
        
    }


}


