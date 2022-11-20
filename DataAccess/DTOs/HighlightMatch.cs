namespace DataAccess.DTOs
{
    public class HighlightMatch
    {
        public string HomeTeam { get; set; } = string.Empty;

        public string AwayTeam { get; set; } = string.Empty;

        public int HomeScore { get; set; }

        public int AwayScore { get; set; }

        public int TotalPoints { get; set; }
    }
}
