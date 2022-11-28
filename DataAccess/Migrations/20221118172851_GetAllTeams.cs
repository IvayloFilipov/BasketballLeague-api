using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class GetAllTeams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"
CREATE PROC [dbo].[GetAllTeams]
AS
SELECT * FROM Teams";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sp = @"DROP PROC [dbo].[GetAllTeams]";

            migrationBuilder.Sql(sp);
        }
    }
}
