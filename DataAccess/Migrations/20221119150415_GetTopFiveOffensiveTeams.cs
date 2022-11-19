using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class GetTopFiveOffensiveTeams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"
CREATE PROC GetTopFiveOffensiveTeams
AS
SELECT TOP(5) t.[Name], TotalScore.[Total point] FROM
(SELECT 
  Result.[TeamId] AS TeamId, 
  SUM(Result.[Total points]) AS 'Total point' 
FROM 
  (
    SELECT 
      mr.[HomeTeamId] AS 'TeamId', 
      SUM(mr.[HomeScore]) AS 'Total points' 
    FROM 
      MatchResults AS mr
    GROUP BY mr.[HomeTeamId]
    UNION ALL
    SELECT 
      mr.[AwayTeamId] AS 'TeamId', 
      SUM(mr.[AwayScore]) AS 'Total points' 
    FROM 
      MatchResults AS mr
    GROUP BY mr.[AwayTeamId]
  ) AS Result 
GROUP BY Result.[TeamId]) AS TotalScore
JOIN Teams AS t ON t.Id = TotalScore.TeamId
ORDER BY TotalScore.[Total point] DESC
";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
