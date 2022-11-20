using Repositories.DTOs;

namespace Repositories.Interfaces
{
    public interface IResultRepositiry
    {
        Task<List<MatchResults>> GetMatchResultsAsync();

        Task<HighlightMatch> GetHighlightMatchAsync();
    }
}
