using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class GetTopFiveDefensiveTeams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"
CREATE PROC GetTopFiveDefensiveTeams
AS
SELECT TOP(5) t.[Name], Result.[DefensivePoints] 
FROM 
  (SELECT 
      DefensivePoints.HomeTeamId AS TeamId, 
      SUM(DefensivePoints.[Defence points]) AS 'DefensivePoints' 
    FROM 
      (
        SELECT 
          mr.HomeTeamId AS 'HomeTeamId', 
          SUM(mr.AwayScore) AS 'Defence points' 
        FROM 
          MatchResults AS mr 
        GROUP BY mr.HomeTeamId 
        UNION ALL 
        SELECT 
          mr.AwayTeamId AS 'AwayTeamId', 
          SUM(mr.HomeScore) AS 'Defence points' 
        FROM 
          MatchResults AS mr 
        GROUP BY mr.AwayTeamId
      ) AS DefensivePoints 
GROUP BY DefensivePoints.HomeTeamId) AS Result 
JOIN Teams AS t ON t.Id = Result.TeamId 
ORDER BY Result.[DefensivePoints] ASC
";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
