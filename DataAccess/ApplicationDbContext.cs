using DataAccess.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

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

            builder.Entity<MatchResult>()
                .HasOne(mr => mr.HomeTeam)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<MatchResult>()
                .HasOne(mr => mr.AwayTeam)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            //builder.Entity<BestDefensiveTeams>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.Property(e => e.Name);
            //    entity.Property(e => e.DefensivePoints);
            //});
        }
    }
}