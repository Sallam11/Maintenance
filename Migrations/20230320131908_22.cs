using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Maintenance.Migrations
{
    public partial class _22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_Machines_ModelIDFK",
                table: "Machines");

            migrationBuilder.DropIndex(
                name: "IX_Machines_OwnerIDFK",
                table: "Machines");

            migrationBuilder.DropIndex(
                name: "IX_Machines_PlaceOfWorkIDFK",
                table: "Machines");

            migrationBuilder.DropIndex(
                name: "IX_Machines_SubGroupIDFK",
                table: "Machines");

            //migrationBuilder.RenameColumn(
            //    name: "Owner_ArName",
            //    table: "Owners",
            //    newName: "Owner_Name");

            migrationBuilder.AddColumn<int>(
                name: "Machine_ID",
                table: "PlaceOfWorks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Machine_ID",
                table: "Owners",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Machine_ID",
                table: "Models",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Machine_ID",
                table: "Machine_SubGroups",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Machine_ID",
                table: "Machine_Groups",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Machine_ID",
                table: "Brands",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlaceOfWorks_Machine_ID",
                table: "PlaceOfWorks",
                column: "Machine_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Owners_Machine_ID",
                table: "Owners",
                column: "Machine_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Models_Machine_ID",
                table: "Models",
                column: "Machine_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Machine_SubGroups_Machine_ID",
                table: "Machine_SubGroups",
                column: "Machine_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Machine_Groups_Machine_ID",
                table: "Machine_Groups",
                column: "Machine_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Brands_Machine_ID",
                table: "Brands",
                column: "Machine_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_Machines_Machine_ID",
                table: "Brands",
                column: "Machine_ID",
                principalTable: "Machines",
                principalColumn: "Machine_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Machine_Groups_Machines_Machine_ID",
                table: "Machine_Groups",
                column: "Machine_ID",
                principalTable: "Machines",
                principalColumn: "Machine_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Machine_SubGroups_Machines_Machine_ID",
                table: "Machine_SubGroups",
                column: "Machine_ID",
                principalTable: "Machines",
                principalColumn: "Machine_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Machines_Machine_ID",
                table: "Models",
                column: "Machine_ID",
                principalTable: "Machines",
                principalColumn: "Machine_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_Machines_Machine_ID",
                table: "Owners",
                column: "Machine_ID",
                principalTable: "Machines",
                principalColumn: "Machine_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PlaceOfWorks_Machines_Machine_ID",
                table: "PlaceOfWorks",
                column: "Machine_ID",
                principalTable: "Machines",
                principalColumn: "Machine_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brands_Machines_Machine_ID",
                table: "Brands");

            migrationBuilder.DropForeignKey(
                name: "FK_Machine_Groups_Machines_Machine_ID",
                table: "Machine_Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Machine_SubGroups_Machines_Machine_ID",
                table: "Machine_SubGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Machines_Machine_ID",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Machines_Machine_ID",
                table: "Owners");

            migrationBuilder.DropForeignKey(
                name: "FK_PlaceOfWorks_Machines_Machine_ID",
                table: "PlaceOfWorks");

            migrationBuilder.DropIndex(
                name: "IX_PlaceOfWorks_Machine_ID",
                table: "PlaceOfWorks");

            migrationBuilder.DropIndex(
                name: "IX_Owners_Machine_ID",
                table: "Owners");

            migrationBuilder.DropIndex(
                name: "IX_Models_Machine_ID",
                table: "Models");

            migrationBuilder.DropIndex(
                name: "IX_Machine_SubGroups_Machine_ID",
                table: "Machine_SubGroups");

            migrationBuilder.DropIndex(
                name: "IX_Machine_Groups_Machine_ID",
                table: "Machine_Groups");

            migrationBuilder.DropIndex(
                name: "IX_Brands_Machine_ID",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "Machine_ID",
                table: "PlaceOfWorks");

            migrationBuilder.DropColumn(
                name: "Machine_ID",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "Machine_ID",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "Machine_ID",
                table: "Machine_SubGroups");

            migrationBuilder.DropColumn(
                name: "Machine_ID",
                table: "Machine_Groups");

            migrationBuilder.DropColumn(
                name: "Machine_ID",
                table: "Brands");

            migrationBuilder.RenameColumn(
                name: "Owner_Name",
                table: "Owners",
                newName: "Owner_ArName");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_BrandIDFK",
                table: "Machines",
                column: "BrandIDFK");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_GroupIDFK",
                table: "Machines",
                column: "GroupIDFK");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_ModelIDFK",
                table: "Machines",
                column: "ModelIDFK");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_OwnerIDFK",
                table: "Machines",
                column: "OwnerIDFK");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_PlaceOfWorkIDFK",
                table: "Machines",
                column: "PlaceOfWorkIDFK");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_SubGroupIDFK",
                table: "Machines",
                column: "SubGroupIDFK");

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
    }
}
