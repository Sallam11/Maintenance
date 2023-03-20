using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Maintenance.Migrations
{
    public partial class _02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brands_Machine_Groups_Machine_GroupsMachineGroup_ID",
                table: "Brands");

            migrationBuilder.DropIndex(
                name: "IX_Brands_Machine_GroupsMachineGroup_ID",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "Machine_GroupsMachineGroup_ID",
                table: "Brands");

            migrationBuilder.CreateIndex(
                name: "IX_Brands_MachineGroupIDFK",
                table: "Brands",
                column: "MachineGroupIDFK");

            migrationBuilder.CreateIndex(
                name: "IX_Brands_MachineSubGroupIDFK",
                table: "Brands",
                column: "MachineSubGroupIDFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_Machine_Groups_MachineGroupIDFK",
                table: "Brands",
                column: "MachineGroupIDFK",
                principalTable: "Machine_Groups",
                principalColumn: "MachineGroup_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_Machine_SubGroups_MachineSubGroupIDFK",
                table: "Brands",
                column: "MachineSubGroupIDFK",
                principalTable: "Machine_SubGroups",
                principalColumn: "MachineSubgroup_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brands_Machine_Groups_MachineGroupIDFK",
                table: "Brands");

            migrationBuilder.DropForeignKey(
                name: "FK_Brands_Machine_SubGroups_MachineSubGroupIDFK",
                table: "Brands");

            migrationBuilder.DropIndex(
                name: "IX_Brands_MachineGroupIDFK",
                table: "Brands");

            migrationBuilder.DropIndex(
                name: "IX_Brands_MachineSubGroupIDFK",
                table: "Brands");

            migrationBuilder.AddColumn<int>(
                name: "Machine_GroupsMachineGroup_ID",
                table: "Brands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Brands_Machine_GroupsMachineGroup_ID",
                table: "Brands",
                column: "Machine_GroupsMachineGroup_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_Machine_Groups_Machine_GroupsMachineGroup_ID",
                table: "Brands",
                column: "Machine_GroupsMachineGroup_ID",
                principalTable: "Machine_Groups",
                principalColumn: "MachineGroup_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
