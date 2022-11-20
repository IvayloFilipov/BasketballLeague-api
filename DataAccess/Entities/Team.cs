using DataAccess.BaseModel;
using System.ComponentModel.DataAnnotations;

using static Common.GlobalConstants;

namespace DataAccess.Entities;

public class Team : BaseModel<int>
{
    [Required]
    [MaxLength(TeamNameMaxLength)]
    public string Name { get; set; } = string.Empty;

    // As here in the project, when I have two FK from MatchResult to Team, two collections must be created!!!
    // many-to-one - one team has many match results
    // public ICollection<MatchResult> MatchResults { get; set; } = new HashSet<MatchResult>();
}
