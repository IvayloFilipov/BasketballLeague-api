using Microsoft.AspNetCore.Mvc;
using Repositories.Interfaces;
using DataAccess.Entities;
using DataAccess.DTOs;

namespace BasketballLeague.WEB.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamRepository teamRepository;
        public TeamsController(ITeamRepository teamRepository) 
        { 
            this.teamRepository = teamRepository;
        }

        [HttpGet("get-teams")]
        public async Task<IActionResult> GetAllTeams()
        {
            List<Team> teams = await this.teamRepository.GetAllTeamsAsync();

            return Ok(teams);
        }

        [HttpGet("get-teams-asc")]
        public async Task<IActionResult> GetAllTeamsASC()
        {
            List<Team> teamsAsc = await this.teamRepository.GetAllTeamsAscAsync();

            return Ok(teamsAsc);
        }

        [HttpGet("get-teams-desc")]
        public async Task<IActionResult> GetAllTeamsDESC()
        {
            List<Team> teamsDesc = await this.teamRepository.GetAllTeamsDescAsync();

            return Ok(teamsDesc);
        }

        [HttpGet("get-top-offensive")]
        public async Task<IActionResult> GetBestOffensiveTeams()
        {
            List<BestOffensiveTeams> bestOffensiveTeams = await this.teamRepository.GetBestOffensiveTeamsAsync();

            return Ok(bestOffensiveTeams);
        }

        [HttpGet("get-top-defensive")]
        public async Task<IActionResult> GetBestDefensiveTeams()
        {
            List<BestDefensiveTeams> bestDefensiveTeams = await this.teamRepository.GetBestDefensiveTeamsAsync();

            return Ok(bestDefensiveTeams);
        }
    }
}
