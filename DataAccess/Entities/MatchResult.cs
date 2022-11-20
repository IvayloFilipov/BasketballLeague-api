using DataAccess.BaseModel;

namespace DataAccess.Entities;

public class MatchResult : BaseModel<int>
{
    public DateTime MatchDate { get; set; }

    // one-to-many 
    public int HomeTeamId { get; set; }
    
    public Team HomeTeam { get; set; } = new Team();

    // one-to-many 
    public int AwayTeamId { get; set; }

    public Team AwayTeam { get; set; } = new Team();


    public int HomeScore { get; set; }

    public int AwayScore { get; set; }
}
