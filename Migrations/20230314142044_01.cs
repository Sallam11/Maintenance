using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Maintenance.Migrations
{
    public partial class _01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branchs",
                columns: table => new
                {
                    Branch_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Branch_ArName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Branch_EngName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branchs", x => x.Branch_ID);
                });

            migrationBuilder.CreateTable(
                name: "DrivingLicenses",
                columns: table => new
                {
                    DrivingLicense_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DrivingLicense_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrivingLicenses", x => x.DrivingLicense_ID);
                });

            migrationBuilder.CreateTable(
                name: "Item_Groups",
                columns: table => new
                {
                    ItemGroup_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemGroup_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item_Groups", x => x.ItemGroup_ID);
                });

            migrationBuilder.CreateTable(
                name: "Machine_Groups",
                columns: table => new
                {
                    MachineGroup_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MachineGroup_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machine_Groups", x => x.MachineGroup_ID);
                });

            migrationBuilder.CreateTable(
                name: "Movement_Types",
                columns: table => new
                {
                    MovementType_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovementType_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movement_Types", x => x.MovementType_ID);
                });

            migrationBuilder.CreateTable(
                name: "OrdersStatuss",
                columns: table => new
                {
                    OrdersStatus_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrdersStatus_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersStatuss", x => x.OrdersStatus_ID);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    Owner_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Owner_ArName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.Owner_ID);
                });

            migrationBuilder.CreateTable(
                name: "PlaceOfWork",
                columns: table => new
                {
                    PlaceOfWork_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaceOfWork_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceOfWork", x => x.PlaceOfWork_ID);
                });

            migrationBuilder.CreateTable(
                name: "Professions",
                columns: table => new
                {
                    Profession_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Profession_ArName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Profession_EngName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professions", x => x.Profession_ID);
                });

            migrationBuilder.CreateTable(
                name: "Item_SubGroups",
                columns: table => new
                {
                    ItemSubGroup_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemGroup_IDFK = table.Column<int>(type: "int", nullable: false),
                    ItemSubGroup_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item_SubGroups", x => x.ItemSubGroup_ID);
                    table.ForeignKey(
                        name: "FK_Item_SubGroups_Item_Groups_ItemGroup_IDFK",
                        column: x => x.ItemGroup_IDFK,
                        principalTable: "Item_Groups",
                        principalColumn: "ItemGroup_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Machine_SubGroups",
                columns: table => new
                {
                    MachineSubgroup_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MachineSubgroup_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MachineGroup_IDFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machine_SubGroups", x => x.MachineSubgroup_ID);
                    table.ForeignKey(
                        name: "FK_Machine_SubGroups_Machine_Groups_MachineGroup_IDFK",
                        column: x => x.MachineGroup_IDFK,
                        principalTable: "Machine_Groups",
                        principalColumn: "MachineGroup_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Employee_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employee_No = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Employee_EngName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Employee_ArName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Employee_Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Employee_Iqama = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Employee_ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchID_FK = table.Column<int>(type: "int", nullable: false),
                    ProfessionID_FK = table.Column<int>(type: "int", nullable: false),
                    DrivingLicenseID_FK = table.Column<int>(type: "int", nullable: false),
                    PlaceOfWorkID_FK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Employee_ID);
                    table.ForeignKey(
                        name: "FK_Employees_Branchs_BranchID_FK",
                        column: x => x.BranchID_FK,
                        principalTable: "Branchs",
                        principalColumn: "Branch_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_DrivingLicenses_DrivingLicenseID_FK",
                        column: x => x.DrivingLicenseID_FK,
                        principalTable: "DrivingLicenses",
                        principalColumn: "DrivingLicense_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_PlaceOfWork_PlaceOfWorkID_FK",
                        column: x => x.PlaceOfWorkID_FK,
                        principalTable: "PlaceOfWork",
                        principalColumn: "PlaceOfWork_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Professions_ProfessionID_FK",
                        column: x => x.ProfessionID_FK,
                        principalTable: "Professions",
                        principalColumn: "Profession_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Item_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Item_Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ItemGroup_IDFK = table.Column<int>(type: "int", nullable: false),
                    ItemSubGroup_IDFK = table.Column<int>(type: "int", nullable: false),
                    Item_Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Item_ID);
                    table.ForeignKey(
                        name: "FK_Items_Item_Groups_ItemGroup_IDFK",
                        column: x => x.ItemGroup_IDFK,
                        principalTable: "Item_Groups",
                        principalColumn: "ItemGroup_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Item_SubGroups_ItemSubGroup_IDFK",
                        column: x => x.ItemSubGroup_IDFK,
                        principalTable: "Item_SubGroups",
                        principalColumn: "ItemSubGroup_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Barnd_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Barnd_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MachineSubgroup_IDFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Barnd_ID);
                    table.ForeignKey(
                        name: "FK_Brands_Machine_SubGroups_MachineSubgroup_IDFK",
                        column: x => x.MachineSubgroup_IDFK,
                        principalTable: "Machine_SubGroups",
                        principalColumn: "MachineSubgroup_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    User_Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    User_Active = table.Column<bool>(type: "bit", nullable: false),
                    EmployeeID_FK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User_ID);
                    table.ForeignKey(
                        name: "FK_Users_Employees_EmployeeID_FK",
                        column: x => x.EmployeeID_FK,
                        principalTable: "Employees",
                        principalColumn: "Employee_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Model_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Barnd_IDFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Model_ID);
                    table.ForeignKey(
                        name: "FK_Models_Brands_Barnd_IDFK",
                        column: x => x.Barnd_IDFK,
                        principalTable: "Brands",
                        principalColumn: "Barnd_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Machines",
                columns: table => new
                {
                    Machine_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Machine_Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    GroupID_FK = table.Column<int>(type: "int", nullable: false),
                    SubGroupID_FK = table.Column<int>(type: "int", nullable: false),
                    BrandID_FK = table.Column<int>(type: "int", nullable: false),
                    ModelID_FK = table.Column<int>(type: "int", nullable: false),
                    OwnerID_FK = table.Column<int>(type: "int", nullable: false),
                    Machine_PlateNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Machine_SerialNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Machine_Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Machine_ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machines", x => x.Machine_ID);
                    table.ForeignKey(
                        name: "FK_Machines_Brands_BrandID_FK",
                        column: x => x.BrandID_FK,
                        principalTable: "Brands",
                        principalColumn: "Barnd_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Machines_Machine_Groups_GroupID_FK",
                        column: x => x.GroupID_FK,
                        principalTable: "Machine_Groups",
                        principalColumn: "MachineGroup_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Machines_Machine_SubGroups_SubGroupID_FK",
                        column: x => x.SubGroupID_FK,
                        principalTable: "Machine_SubGroups",
                        principalColumn: "MachineSubgroup_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Machines_Models_ModelID_FK",
                        column: x => x.ModelID_FK,
                        principalTable: "Models",
                        principalColumn: "Model_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Machines_Owners_OwnerID_FK",
                        column: x => x.OwnerID_FK,
                        principalTable: "Owners",
                        principalColumn: "Owner_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Machine_Movements",
                columns: table => new
                {
                    MachineMovement_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MachineMovement_Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MachineMovement_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MachineMovement_CreatedUserID = table.Column<int>(type: "int", nullable: false),
                    MachineMovement_CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MachineMovement_EditBy = table.Column<int>(type: "int", nullable: false),
                    MachineMovement_EditUserID = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeID_FK = table.Column<int>(type: "int", nullable: false),
                    MovementTypeID_FK = table.Column<int>(type: "int", nullable: false),
                    MachineID_FK = table.Column<int>(type: "int", nullable: false),
                    OrdersStatusID_FK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machine_Movements", x => x.MachineMovement_ID);
                    table.ForeignKey(
                        name: "FK_Machine_Movements_Employees_EmployeeID_FK",
                        column: x => x.EmployeeID_FK,
                        principalTable: "Employees",
                        principalColumn: "Employee_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Machine_Movements_Machines_MachineID_FK",
                        column: x => x.MachineID_FK,
                        principalTable: "Machines",
                        principalColumn: "Machine_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Machine_Movements_Movement_Types_MovementTypeID_FK",
                        column: x => x.MovementTypeID_FK,
                        principalTable: "Movement_Types",
                        principalColumn: "MovementType_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Machine_Movements_OrdersStatuss_OrdersStatusID_FK",
                        column: x => x.OrdersStatusID_FK,
                        principalTable: "OrdersStatuss",
                        principalColumn: "OrdersStatus_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Brands_MachineSubgroup_IDFK",
                table: "Brands",
                column: "MachineSubgroup_IDFK");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_BranchID_FK",
                table: "Employees",
                column: "BranchID_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DrivingLicenseID_FK",
                table: "Employees",
                column: "DrivingLicenseID_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PlaceOfWorkID_FK",
                table: "Employees",
                column: "PlaceOfWorkID_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ProfessionID_FK",
                table: "Employees",
                column: "ProfessionID_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Item_SubGroups_ItemGroup_IDFK",
                table: "Item_SubGroups",
                column: "ItemGroup_IDFK");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemGroup_IDFK",
                table: "Items",
                column: "ItemGroup_IDFK");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemSubGroup_IDFK",
                table: "Items",
                column: "ItemSubGroup_IDFK");

            migrationBuilder.CreateIndex(
                name: "IX_Machine_Movements_EmployeeID_FK",
                table: "Machine_Movements",
                column: "EmployeeID_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Machine_Movements_MachineID_FK",
                table: "Machine_Movements",
                column: "MachineID_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Machine_Movements_MovementTypeID_FK",
                table: "Machine_Movements",
                column: "MovementTypeID_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Machine_Movements_OrdersStatusID_FK",
                table: "Machine_Movements",
                column: "OrdersStatusID_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Machine_SubGroups_MachineGroup_IDFK",
                table: "Machine_SubGroups",
                column: "MachineGroup_IDFK");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_BrandID_FK",
                table: "Machines",
                column: "BrandID_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_GroupID_FK",
                table: "Machines",
                column: "GroupID_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_ModelID_FK",
                table: "Machines",
                column: "ModelID_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_OwnerID_FK",
                table: "Machines",
                column: "OwnerID_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_SubGroupID_FK",
                table: "Machines",
                column: "SubGroupID_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Models_Barnd_IDFK",
                table: "Models",
                column: "Barnd_IDFK");

            migrationBuilder.CreateIndex(
                name: "IX_Users_EmployeeID_FK",
                table: "Users",
                column: "EmployeeID_FK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Machine_Movements");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Item_SubGroups");

            migrationBuilder.DropTable(
                name: "Machines");

            migrationBuilder.DropTable(
                name: "Movement_Types");

            migrationBuilder.DropTable(
                name: "OrdersStatuss");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Item_Groups");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropTable(
                name: "Branchs");

            migrationBuilder.DropTable(
                name: "DrivingLicenses");

            migrationBuilder.DropTable(
                name: "PlaceOfWork");

            migrationBuilder.DropTable(
                name: "Professions");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Machine_SubGroups");

            migrationBuilder.DropTable(
                name: "Machine_Groups");
        }
    }
}
