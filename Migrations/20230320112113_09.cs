using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Maintenance.Migrations
{
    public partial class _09 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Machines_Machine_Groups_GroupID_FK",
                table: "Machines");

            migrationBuilder.DropForeignKey(
                name: "FK_Machines_Machine_SubGroups_SubGroupID_FK",
                table: "Machines");

            migrationBuilder.DropForeignKey(
                name: "FK_Machines_Models_ModelID_FK",
                table: "Machines");

            migrationBuilder.DropForeignKey(
                name: "FK_Machines_Owners_OwnerID_FK",
                table: "Machines");

            migrationBuilder.RenameColumn(
                name: "SubGroupID_FK",
                table: "Machines",
                newName: "SubGroupIDFK");

            migrationBuilder.RenameColumn(
                name: "OwnerID_FK",
                table: "Machines",
                newName: "PlaceOfWorkIDFK");

            migrationBuilder.RenameColumn(
                name: "ModelID_FK",
                table: "Machines",
                newName: "OwnerIDFK");

            migrationBuilder.RenameColumn(
                name: "GroupID_FK",
                table: "Machines",
                newName: "ModelIDFK");

            migrationBuilder.RenameColumn(
                name: "BrandID_FK",
                table: "Machines",
                newName: "GroupIDFK");

            migrationBuilder.RenameIndex(
                name: "IX_Machines_SubGroupID_FK",
                table: "Machines",
                newName: "IX_Machines_SubGroupIDFK");

            migrationBuilder.RenameIndex(
                name: "IX_Machines_OwnerID_FK",
                table: "Machines",
                newName: "IX_Machines_PlaceOfWorkIDFK");

            migrationBuilder.RenameIndex(
                name: "IX_Machines_ModelID_FK",
                table: "Machines",
                newName: "IX_Machines_OwnerIDFK");

            migrationBuilder.RenameIndex(
                name: "IX_Machines_GroupID_FK",
                table: "Machines",
                newName: "IX_Machines_ModelIDFK");

            migrationBuilder.AddColumn<int>(
                name: "BrandIDFK",
                table: "Machines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Machines_BrandIDFK",
                table: "Machines",
                column: "BrandIDFK");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_GroupIDFK",
                table: "Machines",
                column: "GroupIDFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_Brands_BrandIDFK",
                table: "Machines",
                column: "BrandIDFK",
                principalTable: "Brands",
                principalColumn: "Brand_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_Machine_Groups_GroupIDFK",
                table: "Machines",
                column: "GroupIDFK",
                principalTable: "Machine_Groups",
                principalColumn: "MachineGroup_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_Machine_SubGroups_SubGroupIDFK",
                table: "Machines",
                column: "SubGroupIDFK",
                principalTable: "Machine_SubGroups",
                principalColumn: "MachineSubgroup_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_Models_ModelIDFK",
                table: "Machines",
                column: "ModelIDFK",
                principalTable: "Models",
                principalColumn: "Model_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_Owners_OwnerIDFK",
                table: "Machines",
                column: "OwnerIDFK",
                principalTable: "Owners",
                principalColumn: "Owner_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_PlaceOfWorks_PlaceOfWorkIDFK",
                table: "Machines",
                column: "PlaceOfWorkIDFK",
                principalTable: "PlaceOfWorks",
                principalColumn: "PlaceOfWork_ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Machines_Brands_BrandIDFK",
                table: "Machines");

            migrationBuilder.DropForeignKey(
                name: "FK_Machines_Machine_Groups_GroupIDFK",
                table: "Machines");

            migrationBuilder.DropForeignKey(
                name: "FK_Machines_Machine_SubGroups_SubGroupIDFK",
                table: "Machines");

            migrationBuilder.DropForeignKey(
                name: "FK_Machines_Models_ModelIDFK",
                table: "Machines");

            migrationBuilder.DropForeignKey(
                name: "FK_Machines_Owners_OwnerIDFK",
                table: "Machines");

            migrationBuilder.DropForeignKey(
                name: "FK_Machines_PlaceOfWorks_PlaceOfWorkIDFK",
                table: "Machines");

            migrationBuilder.DropIndex(
                name: "IX_Machines_BrandIDFK",
                table: "Machines");

            migrationBuilder.DropIndex(
                name: "IX_Machines_GroupIDFK",
                table: "Machines");

            migrationBuilder.DropColumn(
                name: "BrandIDFK",
                table: "Machines");

            migrationBuilder.RenameColumn(
                name: "SubGroupIDFK",
                table: "Machines",
                newName: "SubGroupID_FK");

            migrationBuilder.RenameColumn(
                name: "PlaceOfWorkIDFK",
                table: "Machines",
                newName: "OwnerID_FK");

            migrationBuilder.RenameColumn(
                name: "OwnerIDFK",
                table: "Machines",
                newName: "ModelID_FK");

            migrationBuilder.RenameColumn(
                name: "ModelIDFK",
                table: "Machines",
                newName: "GroupID_FK");

            migrationBuilder.RenameColumn(
                name: "GroupIDFK",
                table: "Machines",
                newName: "BrandID_FK");

            migrationBuilder.RenameIndex(
                name: "IX_Machines_SubGroupIDFK",
                table: "Machines",
                newName: "IX_Machines_SubGroupID_FK");

            migrationBuilder.RenameIndex(
                name: "IX_Machines_PlaceOfWorkIDFK",
                table: "Machines",
                newName: "IX_Machines_OwnerID_FK");

            migrationBuilder.RenameIndex(
                name: "IX_Machines_OwnerIDFK",
                table: "Machines",
                newName: "IX_Machines_ModelID_FK");

            migrationBuilder.RenameIndex(
                name: "IX_Machines_ModelIDFK",
                table: "Machines",
                newName: "IX_Machines_GroupID_FK");

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_Machine_Groups_GroupID_FK",
                table: "Machines",
                column: "GroupID_FK",
                principalTable: "Machine_Groups",
                principalColumn: "MachineGroup_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_Machine_SubGroups_SubGroupID_FK",
                table: "Machines",
                column: "SubGroupID_FK",
                principalTable: "Machine_SubGroups",
                principalColumn: "MachineSubgroup_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_Models_ModelID_FK",
                table: "Machines",
                column: "ModelID_FK",
                principalTable: "Models",
                principalColumn: "Model_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_Owners_OwnerID_FK",
                table: "Machines",
                column: "OwnerID_FK",
                principalTable: "Owners",
                principalColumn: "Owner_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
