using DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using Repositories.Interfaces;
using DataAccess.DTOs;
using Microsoft.AspNetCore.Cors;

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
