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
	tt.[Name] AS 'Home team', 
	t.[Name] AS 'Away team',  
	mr.HomeScore, mr.AwayScore, 
	(mr.HomeScore + mr.AwayScore) AS 'Total points'
FROM MatchResults AS mr
JOIN Teams AS t ON mr.AwayTeamId = t.Id
JOIN Teams AS tt ON mr.HomeTeamId = tt.Id
ORDER BY 'Total points' DESC
";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
