using DataAccess;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using Repositories.DTOs;

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
            // or
            //var allTeams = await dbContext.Teams.FromSqlRaw($"exec GetAllTeams").ToListAsync();

            return allTeams;
        }

        public async Task<List<BestDefensiveTeams>> GetBestDefensiveTeamsAsync()
        {
            //var defensiveTeams = await dbContext
            //    .Teams
            //    .FromSqlInterpolated($"exec GetTopFiveDefensiveTeams")
            //    .ToListAsync();

            //return defensiveTeams;

            //var defensiveTeams = Helper.RawSqlQuery("exec GetAllTeams", x => new BestDefensiveTeams { Name = (string)x[0], DefensivePoints = (int)x[1] }); 

            //return defensiveTeams;
            throw new NotImplementedException();
        }

        public async Task<List<BestOffensiveTeams>> GetBestOffensiveTeamsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
