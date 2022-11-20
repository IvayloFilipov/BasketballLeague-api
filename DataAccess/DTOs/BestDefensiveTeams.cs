using Microsoft.EntityFrameworkCore;

namespace DataAccess.DTOs
{
    [Keyless]
    public class BestDefensiveTeams
    {
        public string Name { get; set; } = string.Empty;

        public int DefensivePoints { get; set; }
    }
}
