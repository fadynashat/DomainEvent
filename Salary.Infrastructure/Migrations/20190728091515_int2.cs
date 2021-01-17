using Microsoft.EntityFrameworkCore.Migrations;

namespace Salary.Infrastructure.Migrations
{
    public partial class int2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpId",
                table: "Salary",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Sal",
                table: "Salary",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmpId",
                table: "Salary");

            migrationBuilder.DropColumn(
                name: "Sal",
                table: "Salary");
        }
    }
}
