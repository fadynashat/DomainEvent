using Microsoft.EntityFrameworkCore.Migrations;

namespace Salary.Infrastructure.Migrations
{
    public partial class @int : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Sal");

            migrationBuilder.CreateSequence(
                name: "SalarySeq",
                schema: "Sal",
                incrementBy: 10);

            migrationBuilder.CreateTable(
                name: "Salary",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salary", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Salary");

            migrationBuilder.DropSequence(
                name: "SalarySeq",
                schema: "Sal");
        }
    }
}
