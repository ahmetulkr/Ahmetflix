using Ahmetflix.Models;
using Microsoft.EntityFrameworkCore;

namespace Ahmetflix.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Series> Series { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<IMDB> IMDBs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Series>()
                .HasMany(s => s.Seasons)
                .WithOne()
                .HasForeignKey(s => s.SeriesId);

            modelBuilder.Entity<Series>()
                .HasMany(s => s.Casts)
                .WithOne()
                .HasForeignKey(c => c.SeriesId);
        }
    }
}


