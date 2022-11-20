using DataAccess.DTOs;
using DataAccess.Entities;
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


        // Keyless entity types
        public DbSet<BestDefensiveTeams> BestDefensiveTeams { get; set; } = null!;
        public DbSet<BestOffensiveTeams> BestOffensiveTeams { get; set; } = null!;
        public DbSet<HighlightMatch> HighlightMatch { get; set; } = null!;
        public DbSet<MatchResults> MatchesResults { get; set; } = null!;


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

            // Keyless entiti types
            builder.Entity<BestDefensiveTeams>().HasNoKey();

            builder.Entity<BestOffensiveTeams>().HasNoKey();

            builder.Entity<HighlightMatch>().HasNoKey();

            builder.Entity<MatchResults>().HasNoKey();
        }
    }
}