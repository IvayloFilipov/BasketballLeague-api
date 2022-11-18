using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // dbcc checkident ('Teams', reseed, 0)

            migrationBuilder.Sql(@"
INSERT INTO Teams VALUES ('Sofia'), ('Varna'), ('Plovdiv'), ('Burgas'), ('Ruse'), ('Kaspichan');
");
            migrationBuilder.Sql(@"
INSERT INTO MatchResults ([MatchDate], [HomeTeamId], [AwayTeamId], [HomeScore], [AwayScore]) VALUES 
('2022-03-14', 1, 2, 15, 100),
('2022-03-14', 1, 3, 100, 10),
('2022-03-15', 1, 4, 99, 100),
('2022-03-15', 1, 5, 85, 55),
('2022-03-16', 1, 6, 75, 107),
('2022-03-16', 2, 3, 125, 80),
('2022-03-17', 2, 4, 65, 90),
('2022-03-17', 2, 6, 95, 70),
('2022-03-18', 2, 5, 75, 70),
('2022-03-18', 3, 4, 105, 90),
('2022-03-19', 3, 5, 165, 108),
('2022-03-19', 3, 5, 25, 10),
('2022-03-24', 4, 5, 65, 70),
('2022-03-24', 4, 6, 18, 90),
('2022-04-14', 5, 6, 85, 90),
('2022-04-14', 2, 1, 89, 96),
('2022-05-14', 3, 1, 84, 92),
('2022-05-14', 4, 1, 87, 95),
('2022-06-14', 5, 1, 82, 89),
('2022-06-14', 6, 1, 81, 75);
");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
