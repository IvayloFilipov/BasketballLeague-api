using DataAccess.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DB Sets
        public DbSet<Team> Teams { get; set; } = null!;

        public DbSet<MatchResult> MatchResults { get; set; } = null!;


        // One-to-many, Many-to-many relations, Composite key - with fluent API
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.Entity<Team>()
            //    .HasMany(mr => mr.MatchResults)
            //    .WithOne(t => t.HomeTeam)
            //    .OnDelete(DeleteBehavior.Restrict);

            //builder.Entity<Team>()
            //    .HasMany(tr => tr.MatchResults)
            //    .WithOne(t => t.AwayTeam)
            //    .OnDelete(DeleteBehavior.Restrict);

        }
    }
}