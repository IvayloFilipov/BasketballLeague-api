using DataAccess.BaseModel;
using System.ComponentModel.DataAnnotations;

using static Common.GlobalConstants;

namespace DataAccess.Entities;

public class Team : BaseModel<int>
{
    [Required]
    [MaxLength(TeamNameMaxLength)]
    public string Name { get; set; } = string.Empty;

    // many-to-one - one team has many match results
    public ICollection<MatchResult> MatchResults { get; set; } = new HashSet<MatchResult>();
}
