using DataAccess.Entities;
using DataAccess.DTOs;

namespace Repositories.Interfaces
{
    public interface ITeamRepository
    {
        Task<List<Team>> GetAllTeamsAsync();

        Task<List<Team>> GetAllTeamsAscAsync();

        Task<List<Team>> GetAllTeamsDescAsync();

        Task<List<BestOffensiveTeams>> GetBestOffensiveTeamsAsync();

        Task<List<BestDefensiveTeams>> GetBestDefensiveTeamsAsync();
    }
}
