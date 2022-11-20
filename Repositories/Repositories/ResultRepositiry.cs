using DataAccess;
using Repositories.Interfaces;
using Repositories.DTOs;

namespace Repositories.Repositories
{
    public class ResultRepositiry : IResultRepositiry
    {
        private readonly ApplicationDbContext dbContext;

        public ResultRepositiry(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<HighlightMatch> GetHighlightMatchAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<MatchResults>> GetMatchResultsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
