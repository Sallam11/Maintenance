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
                name: "Branch",
                columns: table => new
                {
                    Branch_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Branch_ArName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Branch_EngName = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.Branch_ID);
                });

            migrationBuilder.CreateTable(
                name: "Brand_Groups",
                columns: table => new
                {
                    BarndGroup_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BarndGroup_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand_Groups", x => x.BarndGroup_ID);
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
                name: "Professions",
                columns: table => new
                {
                    Profession_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Profession_ArName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Profession_EngName = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professions", x => x.Profession_ID);
                });

            migrationBuilder.CreateTable(
                name: "Work_Types",
                columns: table => new
                {
                    WorkType_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkType_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Work_Types", x => x.WorkType_ID);
                });

            migrationBuilder.CreateTable(
                name: "Brand_SubGroups",
                columns: table => new
                {
                    BarndSubgroup_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BarndSubgroup_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BarndGroup_IDFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand_SubGroups", x => x.BarndSubgroup_ID);
                    table.ForeignKey(
                        name: "FK_Brand_SubGroups_Brand_Groups_BarndGroup_IDFK",
                        column: x => x.BarndGroup_IDFK,
                        principalTable: "Brand_Groups",
                        principalColumn: "BarndGroup_ID",
                        onDelete: ReferentialAction.Restrict);
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
                name: "Employees",
                columns: table => new
                {
                    Employee_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employee_No = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Employee_EngName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Employee_ArName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Employee_Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Employee_BranchID = table.Column<int>(type: "int", nullable: false),
                    Employee_ProfessionID = table.Column<int>(type: "int", nullable: false),
                    Employee_iqama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Employee_ID);
                    table.ForeignKey(
                        name: "FK_Employees_Branch_Employee_BranchID",
                        column: x => x.Employee_BranchID,
                        principalTable: "Branch",
                        principalColumn: "Branch_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Professions_Employee_ProfessionID",
                        column: x => x.Employee_ProfessionID,
                        principalTable: "Professions",
                        principalColumn: "Profession_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Machines",
                columns: table => new
                {
                    Machine_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Machine_No = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Machine_PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Machine_Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    GroupID_FK = table.Column<int>(type: "int", nullable: false),
                    SubGroupID_FK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machines", x => x.Machine_ID);
                    table.ForeignKey(
                        name: "FK_Machines_Brand_Groups_GroupID_FK",
                        column: x => x.GroupID_FK,
                        principalTable: "Brand_Groups",
                        principalColumn: "BarndGroup_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Machines_Brand_SubGroups_SubGroupID_FK",
                        column: x => x.SubGroupID_FK,
                        principalTable: "Brand_SubGroups",
                        principalColumn: "BarndSubgroup_ID",
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
                    WorkTypeID_FK = table.Column<int>(type: "int", nullable: false)
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
                        name: "FK_Machine_Movements_Work_Types_WorkTypeID_FK",
                        column: x => x.WorkTypeID_FK,
                        principalTable: "Work_Types",
                        principalColumn: "WorkType_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Brand_SubGroups_BarndGroup_IDFK",
                table: "Brand_SubGroups",
                column: "BarndGroup_IDFK");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Employee_BranchID",
                table: "Employees",
                column: "Employee_BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Employee_ProfessionID",
                table: "Employees",
                column: "Employee_ProfessionID");

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
                name: "IX_Machine_Movements_WorkTypeID_FK",
                table: "Machine_Movements",
                column: "WorkTypeID_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_GroupID_FK",
                table: "Machines",
                column: "GroupID_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_SubGroupID_FK",
                table: "Machines",
                column: "SubGroupID_FK");

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
                name: "Work_Types");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Item_Groups");

            migrationBuilder.DropTable(
                name: "Brand_SubGroups");

            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.DropTable(
                name: "Professions");

            migrationBuilder.DropTable(
                name: "Brand_Groups");
        }
    }
}
