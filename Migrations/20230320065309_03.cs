using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Maintenance.Migrations
{
    public partial class _03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Barnd_IDFK",
                table: "Models",
                newName: "BarndIDFK");

            migrationBuilder.CreateIndex(
                name: "IX_Models_BarndIDFK",
                table: "Models",
                column: "BarndIDFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Brands_BarndIDFK",
                table: "Models",
                column: "BarndIDFK",
                principalTable: "Brands",
                principalColumn: "Brand_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Brands_BarndIDFK",
                table: "Models");

            migrationBuilder.DropIndex(
                name: "IX_Models_BarndIDFK",
                table: "Models");

            migrationBuilder.RenameColumn(
                name: "BarndIDFK",
                table: "Models",
                newName: "Barnd_IDFK");
        }
    }
}
