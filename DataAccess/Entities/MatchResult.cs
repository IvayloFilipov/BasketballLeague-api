using DataAccess.BaseModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities;

public class MatchResult : BaseModel<int>
{
    public DateTime MatchDate { get; set; }

    // one-to-many 
    [ForeignKey(nameof(Team))]
    public int HomeTeamId { get; set; }

    public Team HomeTeam { get; set; } = new Team();

    // one-to-many 
    [ForeignKey(nameof(Team))]
    public int AwayTeamId { get; set; }

    public Team AwayTeam { get; set; } = new Team();


    public int HomeScore { get; set; }

    public int AwayScore { get; set; }

    public int MatchTotalScore => this.HomeScore + this.AwayScore;
}
