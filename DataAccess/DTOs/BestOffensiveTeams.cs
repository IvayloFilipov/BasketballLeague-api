using Microsoft.EntityFrameworkCore;

namespace DataAccess.DTOs
{
    [Keyless]
    public class BestOffensiveTeams
    {
        public string Name { get; set; } = string.Empty;

        public int TotalPoints { get; set; }
    }
}
