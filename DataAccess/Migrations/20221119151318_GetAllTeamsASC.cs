using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class GetAllTeamsASC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"
CREATE PROC GetAllTeamsASC
AS
SELECT * FROM Teams AS t
ORDER BY t.[Name] ASC
";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sp = @"DROP PROC GetAllTeamsASC";

            migrationBuilder.Sql(sp);
        }
    }
}
