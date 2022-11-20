using DataAccess.DTOs;

namespace Repositories.Interfaces
{
    public interface IResultRepositiry
    {
        Task<List<MatchResults>> GetMatchResultsAsync();

        Task<List<HighlightMatch>> GetHighlightMatchAsync();
    }
}
