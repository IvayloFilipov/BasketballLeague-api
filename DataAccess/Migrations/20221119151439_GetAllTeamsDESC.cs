using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class GetAllTeamsDESC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"
CREATE PROC GetAllTeamsDESC
AS
SELECT * FROM Teams AS t
ORDER BY t.[Name] DESC
";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sp = @"DROP PROC GetAllTeamsDESC";

            migrationBuilder.Sql(sp);
        }
    }
}
