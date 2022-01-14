using Microsoft.EntityFrameworkCore.Migrations;

namespace IntentoCF.Migrations
{
    public partial class Migracion1401LastName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "People",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                table: "People");
        }
    }
}
