using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class GetHighlightMatch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"
CREATE PROC GetHighlightMatch
AS
SELECT TOP(1) 
	tt.[Name] AS 'HomeTeam', 
	t.[Name] AS 'AwayTeam',  
	mr.HomeScore, mr.AwayScore, 
	(mr.HomeScore + mr.AwayScore) AS 'TotalPoints'
FROM MatchResults AS mr
JOIN Teams AS t ON mr.AwayTeamId = t.Id
JOIN Teams AS tt ON mr.HomeTeamId = tt.Id
ORDER BY 'TotalPoints' DESC
";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
