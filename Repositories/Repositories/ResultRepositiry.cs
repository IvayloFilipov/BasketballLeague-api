using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using DataAccess.DTOs;
using DataAccess;

namespace Repositories.Repositories
{
    public class ResultRepositiry : IResultRepositiry
    {
        private readonly ApplicationDbContext dbContext;

        public ResultRepositiry(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<HighlightMatch>> GetHighlightMatchAsync()
        {
            var highlightMatch = await dbContext
                .HighlightMatch
                .FromSqlInterpolated($"exec GetHighlightMatch")
                .ToListAsync();

            return highlightMatch;
        }

        public async Task<List<MatchResults>> GetMatchResultsAsync()
        {
            var matchResults = await dbContext
                .MatchesResults
                .FromSqlInterpolated($"exec GetLastTenMatches")
                .ToListAsync();

            return matchResults;
        }
    }
}
