using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Maintenance.Migrations
{
    public partial class _08 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Branchs_BranchID_FK",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_DrivingLicenses_DrivingLicenseID_FK",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_PlaceOfWorks_PlaceOfWorkID_FK",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Professions_ProfessionID_FK",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "ProfessionID_FK",
                table: "Employees",
                newName: "ProfessionIDFK");

            migrationBuilder.RenameColumn(
                name: "PlaceOfWorkID_FK",
                table: "Employees",
                newName: "PlaceOfWorkIDFK");

            migrationBuilder.RenameColumn(
                name: "DrivingLicenseID_FK",
                table: "Employees",
                newName: "DrivingLicenseIDFK");

            migrationBuilder.RenameColumn(
                name: "BranchID_FK",
                table: "Employees",
                newName: "BranchIDFK");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_ProfessionID_FK",
                table: "Employees",
                newName: "IX_Employees_ProfessionIDFK");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_PlaceOfWorkID_FK",
                table: "Employees",
                newName: "IX_Employees_PlaceOfWorkIDFK");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_DrivingLicenseID_FK",
                table: "Employees",
                newName: "IX_Employees_DrivingLicenseIDFK");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_BranchID_FK",
                table: "Employees",
                newName: "IX_Employees_BranchIDFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Branchs_BranchIDFK",
                table: "Employees",
                column: "BranchIDFK",
                principalTable: "Branchs",
                principalColumn: "Branch_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_DrivingLicenses_DrivingLicenseIDFK",
                table: "Employees",
                column: "DrivingLicenseIDFK",
                principalTable: "DrivingLicenses",
                principalColumn: "DrivingLicense_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_PlaceOfWorks_PlaceOfWorkIDFK",
                table: "Employees",
                column: "PlaceOfWorkIDFK",
                principalTable: "PlaceOfWorks",
                principalColumn: "PlaceOfWork_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Professions_ProfessionIDFK",
                table: "Employees",
                column: "ProfessionIDFK",
                principalTable: "Professions",
                principalColumn: "Profession_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Branchs_BranchIDFK",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_DrivingLicenses_DrivingLicenseIDFK",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_PlaceOfWorks_PlaceOfWorkIDFK",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Professions_ProfessionIDFK",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "ProfessionIDFK",
                table: "Employees",
                newName: "ProfessionID_FK");

            migrationBuilder.RenameColumn(
                name: "PlaceOfWorkIDFK",
                table: "Employees",
                newName: "PlaceOfWorkID_FK");

            migrationBuilder.RenameColumn(
                name: "DrivingLicenseIDFK",
                table: "Employees",
                newName: "DrivingLicenseID_FK");

            migrationBuilder.RenameColumn(
                name: "BranchIDFK",
                table: "Employees",
                newName: "BranchID_FK");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_ProfessionIDFK",
                table: "Employees",
                newName: "IX_Employees_ProfessionID_FK");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_PlaceOfWorkIDFK",
                table: "Employees",
                newName: "IX_Employees_PlaceOfWorkID_FK");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_DrivingLicenseIDFK",
                table: "Employees",
                newName: "IX_Employees_DrivingLicenseID_FK");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_BranchIDFK",
                table: "Employees",
                newName: "IX_Employees_BranchID_FK");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Branchs_BranchID_FK",
                table: "Employees",
                column: "BranchID_FK",
                principalTable: "Branchs",
                principalColumn: "Branch_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_DrivingLicenses_DrivingLicenseID_FK",
                table: "Employees",
                column: "DrivingLicenseID_FK",
                principalTable: "DrivingLicenses",
                principalColumn: "DrivingLicense_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_PlaceOfWorks_PlaceOfWorkID_FK",
                table: "Employees",
                column: "PlaceOfWorkID_FK",
                principalTable: "PlaceOfWorks",
                principalColumn: "PlaceOfWork_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Professions_ProfessionID_FK",
                table: "Employees",
                column: "ProfessionID_FK",
                principalTable: "Professions",
                principalColumn: "Profession_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
