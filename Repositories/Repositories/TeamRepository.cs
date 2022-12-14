using Microsoft.EntityFrameworkCore;
using DataAccess;
using DataAccess.DTOs;
using DataAccess.Entities;
using Repositories.Interfaces;

namespace Repositories.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly ApplicationDbContext dbContext;

        public TeamRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<List<Team>> GetAllTeamsAsync()
        {
            var allTeams = await dbContext
                .Teams
                .FromSqlInterpolated($"exec GetAllTeams")
                .ToListAsync();

            return allTeams;
        }

        public async Task<List<Team>> GetAllTeamsAscAsync()
        {
            var allTeamsASC = await dbContext
                .Teams
                .FromSqlInterpolated($"exec GetAllTeamsASC")
                .ToListAsync();

            return allTeamsASC;
        }

        public async Task<List<Team>> GetAllTeamsDescAsync()
        {
            var allTeamsDESC = await dbContext
                .Teams
                .FromSqlInterpolated($"exec GetAllTeamsDESC")
                .ToListAsync();

            return allTeamsDESC;
        }

        public async Task<List<BestDefensiveTeams>> GetBestDefensiveTeamsAsync()
        {
            var defensiveTeams = await dbContext
                .BestDefensiveTeams
                .FromSqlInterpolated($"exec GetTopFiveDefensiveTeams")
                .ToListAsync();

            return defensiveTeams;
        }

        public async Task<List<BestOffensiveTeams>> GetBestOffensiveTeamsAsync()
        {
            var offensiveTeams = await dbContext
                .BestOffensiveTeams
                .FromSqlInterpolated($"exec GetTopFiveOffensiveTeams")
                .ToListAsync();

            return offensiveTeams;
        }
    }
}
