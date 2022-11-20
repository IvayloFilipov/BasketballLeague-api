using DataAccess.Entities;
using Repositories.DTOs;

namespace Repositories.Interfaces
{
    public interface ITeamRepository
    {
        Task<List<Team>> GetAllTeamsAsync();

        Task<List<BestOffensiveTeams>> GetBestOffensiveTeamsAsync();

        Task<List<BestDefensiveTeams>> GetBestDefensiveTeamsAsync();
    }
}
