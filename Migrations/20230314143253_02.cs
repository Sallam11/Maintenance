using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Maintenance.Migrations
{
    public partial class _02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_PlaceOfWork_PlaceOfWorkID_FK",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlaceOfWork",
                table: "PlaceOfWork");

            migrationBuilder.RenameTable(
                name: "PlaceOfWork",
                newName: "PlaceOfWorks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlaceOfWorks",
                table: "PlaceOfWorks",
                column: "PlaceOfWork_ID");

            migrationBuilder.CreateTable(
                name: "OperatingCards",
                columns: table => new
                {
                    OperatingCard_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperatingCard_ArName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatingCards", x => x.OperatingCard_ID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_PlaceOfWorks_PlaceOfWorkID_FK",
                table: "Employees",
                column: "PlaceOfWorkID_FK",
                principalTable: "PlaceOfWorks",
                principalColumn: "PlaceOfWork_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_PlaceOfWorks_PlaceOfWorkID_FK",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "OperatingCards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlaceOfWorks",
                table: "PlaceOfWorks");

            migrationBuilder.RenameTable(
                name: "PlaceOfWorks",
                newName: "PlaceOfWork");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlaceOfWork",
                table: "PlaceOfWork",
                column: "PlaceOfWork_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_PlaceOfWork_PlaceOfWorkID_FK",
                table: "Employees",
                column: "PlaceOfWorkID_FK",
                principalTable: "PlaceOfWork",
                principalColumn: "PlaceOfWork_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
