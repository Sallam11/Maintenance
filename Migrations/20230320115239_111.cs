using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Maintenance.Migrations
{
    public partial class _111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Owner_ArName",
                table: "Owners",
                newName: "Owner_Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Owner_ArName",
                table: "Owners",
                newName: "Owner_Name");
        }
    }
}
