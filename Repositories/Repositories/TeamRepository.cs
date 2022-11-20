using DataAccess;
using DataAccess.DTOs;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
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
            throw new NotImplementedException();
        }
    }
}
