using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class GetLastTenMatches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"
CREATE PROC GetLastTenMatches
AS
SELECT TOP(10) 
	tt.[Name] AS 'HomeTeam', 
	t.[Name] AS 'AwayTeam',  
	mr.HomeScore, mr.AwayScore
FROM MatchResults AS mr
JOIN Teams AS t ON mr.AwayTeamId = t.Id
JOIN Teams AS tt ON mr.HomeTeamId = tt.Id
ORDER BY mr.MatchDate DESC
";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
