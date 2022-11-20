using Microsoft.AspNetCore.Mvc;
using Repositories.Interfaces;
using DataAccess.DTOs;
using Microsoft.AspNetCore.Cors;

namespace BasketballLeague.WEB.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MatchesController : ControllerBase
    {
        private readonly IResultRepositiry resultRepositiry;

        public MatchesController(IResultRepositiry resultRepositiry)
        {
            this.resultRepositiry = resultRepositiry;
        }

        [HttpGet("get-results")]
        public async Task<IActionResult> GetMachResults()
        {
            List<MatchResults> matchResults = await this.resultRepositiry.GetMatchResultsAsync();

            return Ok(matchResults);
        }

        [HttpGet("get-highlight-match")]
        public async Task<IActionResult> GetHighlightMatch()
        {
            var highlightMatch = await this.resultRepositiry.GetHighlightMatchAsync();

            return Ok(highlightMatch);
        }
    }
}
