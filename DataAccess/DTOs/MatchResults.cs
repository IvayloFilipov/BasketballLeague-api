﻿namespace DataAccess.DTOs
{
    public class MatchResults
    {
        public string HomeTeam { get; set; } = string.Empty;

        public string AwayTeam { get; set; } = string.Empty;

        public int HomeScore { get; set; }

        public int AwayScore { get; set; }

    }
}