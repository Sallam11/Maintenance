﻿// <auto-generated />
using System;
using Maintenance.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Maintenance.Migrations
{
    [DbContext(typeof(MaintenanceDbContext))]
    [Migration("20230320074618_05")]
    partial class _05
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Machine_Movement", b =>
                {
                    b.Property<int>("MachineMovement_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MachineMovement_ID"), 1L, 1);

                    b.Property<int>("EmployeeID_FK")
                        .HasColumnType("int");

                    b.Property<int>("MachineID_FK")
                        .HasColumnType("int");

                    b.Property<DateTime>("MachineMovement_CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MachineMovement_CreatedUserID")
                        .HasColumnType("int");

                    b.Property<DateTime>("MachineMovement_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("MachineMovement_EditBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("MachineMovement_EditUserID")
                        .HasColumnType("datetime2");

                    b.Property<string>("MachineMovement_Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovementTypeID_FK")
                        .HasColumnType("int");

                    b.Property<int>("OrdersStatusID_FK")
                        .HasColumnType("int");

                    b.HasKey("MachineMovement_ID");

                    b.HasIndex("EmployeeID_FK");

                    b.HasIndex("MachineID_FK");

                    b.HasIndex("MovementTypeID_FK");

                    b.HasIndex("OrdersStatusID_FK");

                    b.ToTable("Machine_Movements");
                });

            modelBuilder.Entity("Maintenance.Models.Branch", b =>
                {
                    b.Property<int>("Branch_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Branch_ID"), 1L, 1);

                    b.Property<string>("Branch_ArName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Branch_EngName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Branch_ID");

                    b.ToTable("Branchs");
                });

            modelBuilder.Entity("Maintenance.Models.Brand", b =>
                {
                    b.Property<int>("Brand_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Brand_ID"), 1L, 1);

                    b.Property<string>("Brand_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("MachineGroupIDFK")
                        .HasColumnType("int");

                    b.Property<int>("MachineSubGroupIDFK")
                        .HasColumnType("int");

                    b.HasKey("Brand_ID");

                    b.HasIndex("MachineGroupIDFK");

                    b.HasIndex("MachineSubGroupIDFK");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Maintenance.Models.DrivingLicense", b =>
                {
                    b.Property<int>("DrivingLicense_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DrivingLicense_ID"), 1L, 1);

                    b.Property<string>("DrivingLicense_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("DrivingLicense_ID");

                    b.ToTable("DrivingLicenses");
                });

            modelBuilder.Entity("Maintenance.Models.Employee", b =>
                {
                    b.Property<int>("Employee_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Employee_ID"), 1L, 1);

                    b.Property<int>("BranchID_FK")
                        .HasColumnType("int");

                    b.Property<int>("DrivingLicenseID_FK")
                        .HasColumnType("int");

                    b.Property<string>("Employee_ArName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Employee_EngName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Employee_ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Employee_Iqama")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Employee_No")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Employee_Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("PlaceOfWorkID_FK")
                        .HasColumnType("int");

                    b.Property<int>("ProfessionID_FK")
                        .HasColumnType("int");

                    b.HasKey("Employee_ID");

                    b.HasIndex("BranchID_FK");

                    b.HasIndex("DrivingLicenseID_FK");

                    b.HasIndex("PlaceOfWorkID_FK");

                    b.HasIndex("ProfessionID_FK");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Maintenance.Models.Item", b =>
                {
                    b.Property<int>("Item_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Item_ID"), 1L, 1);

                    b.Property<int>("ItemGroupIDFK")
                        .HasColumnType("int");

                    b.Property<int>("ItemSubGroupIDFK")
                        .HasColumnType("int");

                    b.Property<string>("Item_Code")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Item_Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Item_ID");

                    b.HasIndex("ItemGroupIDFK");

                    b.HasIndex("ItemSubGroupIDFK");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Maintenance.Models.Item_Group", b =>
                {
                    b.Property<int>("ItemGroup_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemGroup_ID"), 1L, 1);

                    b.Property<string>("ItemGroup_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ItemGroup_ID");

                    b.ToTable("Item_Groups");
                });

            modelBuilder.Entity("Maintenance.Models.Item_SubGroup", b =>
                {
                    b.Property<int>("ItemSubGroup_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemSubGroup_ID"), 1L, 1);

                    b.Property<int>("ItemGroupIDFK")
                        .HasColumnType("int");

                    b.Property<string>("ItemSubGroup_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ItemSubGroup_ID");

                    b.HasIndex("ItemGroupIDFK");

                    b.ToTable("Item_SubGroups");
                });

            modelBuilder.Entity("Maintenance.Models.Machine", b =>
                {
                    b.Property<int>("Machine_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Machine_ID"), 1L, 1);

                    b.Property<int>("BrandID_FK")
                        .HasColumnType("int");

                    b.Property<int>("GroupID_FK")
                        .HasColumnType("int");

                    b.Property<string>("Machine_Code")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Machine_ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Machine_Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Machine_PlateNo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Machine_SerialNo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("ModelID_FK")
                        .HasColumnType("int");

                    b.Property<int>("OwnerID_FK")
                        .HasColumnType("int");

                    b.Property<int>("SubGroupID_FK")
                        .HasColumnType("int");

                    b.HasKey("Machine_ID");

                    b.HasIndex("GroupID_FK");

                    b.HasIndex("ModelID_FK");

                    b.HasIndex("OwnerID_FK");

                    b.HasIndex("SubGroupID_FK");

                    b.ToTable("Machines");
                });

            modelBuilder.Entity("Maintenance.Models.Machine_Group", b =>
                {
                    b.Property<int>("MachineGroup_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MachineGroup_ID"), 1L, 1);

                    b.Property<string>("MachineGroup_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MachineGroup_ID");

                    b.ToTable("Machine_Groups");
                });

            modelBuilder.Entity("Maintenance.Models.Machine_SubGroup", b =>
                {
                    b.Property<int>("MachineSubgroup_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MachineSubgroup_ID"), 1L, 1);

                    b.Property<int>("MachineGroupIDFK")
                        .HasColumnType("int");

                    b.Property<string>("MachineSubgroup_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MachineSubgroup_ID");

                    b.HasIndex("MachineGroupIDFK");

                    b.ToTable("Machine_SubGroups");
                });

            modelBuilder.Entity("Maintenance.Models.Model", b =>
                {
                    b.Property<int>("Model_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Model_ID"), 1L, 1);

                    b.Property<int>("BarndIDFK")
                        .HasColumnType("int");

                    b.Property<string>("Model_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Model_ID");

                    b.HasIndex("BarndIDFK");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("Maintenance.Models.Movement_Type", b =>
                {
                    b.Property<int>("MovementType_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovementType_ID"), 1L, 1);

                    b.Property<string>("MovementType_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MovementType_ID");

                    b.ToTable("Movement_Types");
                });

            modelBuilder.Entity("Maintenance.Models.OperatingCard", b =>
                {
                    b.Property<int>("OperatingCard_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OperatingCard_ID"), 1L, 1);

                    b.Property<string>("OperatingCard_ArName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("OperatingCard_ID");

                    b.ToTable("OperatingCards");
                });

            modelBuilder.Entity("Maintenance.Models.OrdersStatus", b =>
                {
                    b.Property<int>("OrdersStatus_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrdersStatus_ID"), 1L, 1);

                    b.Property<string>("OrdersStatus_Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("OrdersStatus_ID");

                    b.ToTable("OrdersStatuss");
                });

            modelBuilder.Entity("Maintenance.Models.Owner", b =>
                {
                    b.Property<int>("Owner_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Owner_ID"), 1L, 1);

                    b.Property<string>("Owner_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Owner_ID");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("Maintenance.Models.PlaceOfWork", b =>
                {
                    b.Property<int>("PlaceOfWork_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlaceOfWork_ID"), 1L, 1);

                    b.Property<string>("PlaceOfWork_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PlaceOfWork_ID");

                    b.ToTable("PlaceOfWorks");
                });

            modelBuilder.Entity("Maintenance.Models.Profession", b =>
                {
                    b.Property<int>("Profession_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Profession_ID"), 1L, 1);

                    b.Property<string>("Profession_ArName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Profession_EngName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Profession_ID");

                    b.ToTable("Professions");
                });

            modelBuilder.Entity("Maintenance.Models.User", b =>
                {
                    b.Property<int>("User_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("User_ID"), 1L, 1);

                    b.Property<int>("EmployeeID_FK")
                        .HasColumnType("int");

                    b.Property<bool>("User_Active")
                        .HasColumnType("bit");

                    b.Property<string>("User_Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("User_Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("User_ID");

                    b.HasIndex("EmployeeID_FK");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Machine_Movement", b =>
                {
                    b.HasOne("Maintenance.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Maintenance.Models.Machine", "Machine")
                        .WithMany()
                        .HasForeignKey("MachineID_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Maintenance.Models.Movement_Type", "Movement_Type")
                        .WithMany()
                        .HasForeignKey("MovementTypeID_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Maintenance.Models.OrdersStatus", "OrdersStatus")
                        .WithMany()
                        .HasForeignKey("OrdersStatusID_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Machine");

                    b.Navigation("Movement_Type");

                    b.Navigation("OrdersStatus");
                });

            modelBuilder.Entity("Maintenance.Models.Brand", b =>
                {
                    b.HasOne("Maintenance.Models.Machine_Group", "Machine_Groups")
                        .WithMany()
                        .HasForeignKey("MachineGroupIDFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Maintenance.Models.Machine_SubGroup", "Machine_SubGroups")
                        .WithMany()
                        .HasForeignKey("MachineSubGroupIDFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Machine_Groups");

                    b.Navigation("Machine_SubGroups");
                });

            modelBuilder.Entity("Maintenance.Models.Employee", b =>
                {
                    b.HasOne("Maintenance.Models.Branch", "Branchs")
                        .WithMany()
                        .HasForeignKey("BranchID_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Maintenance.Models.DrivingLicense", "DrivingLicenses")
                        .WithMany()
                        .HasForeignKey("DrivingLicenseID_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Maintenance.Models.PlaceOfWork", "PlaceOfWorks")
                        .WithMany()
                        .HasForeignKey("PlaceOfWorkID_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Maintenance.Models.Profession", "Professions")
                        .WithMany()
                        .HasForeignKey("ProfessionID_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branchs");

                    b.Navigation("DrivingLicenses");

                    b.Navigation("PlaceOfWorks");

                    b.Navigation("Professions");
                });

            modelBuilder.Entity("Maintenance.Models.Item", b =>
                {
                    b.HasOne("Maintenance.Models.Item_Group", "Item_Groups")
                        .WithMany()
                        .HasForeignKey("ItemGroupIDFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Maintenance.Models.Item_SubGroup", "Item_SubGroups")
                        .WithMany()
                        .HasForeignKey("ItemSubGroupIDFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item_Groups");

                    b.Navigation("Item_SubGroups");
                });

            modelBuilder.Entity("Maintenance.Models.Item_SubGroup", b =>
                {
                    b.HasOne("Maintenance.Models.Item_Group", "Item_Groups")
                        .WithMany()
                        .HasForeignKey("ItemGroupIDFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item_Groups");
                });

            modelBuilder.Entity("Maintenance.Models.Machine", b =>
                {
                    b.HasOne("Maintenance.Models.Machine_Group", "Machine_Groups")
                        .WithMany()
                        .HasForeignKey("GroupID_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Maintenance.Models.Model", "Models")
                        .WithMany()
                        .HasForeignKey("ModelID_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Maintenance.Models.Owner", "Owners")
                        .WithMany()
                        .HasForeignKey("OwnerID_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Maintenance.Models.Machine_SubGroup", "Machine_SubGroups")
                        .WithMany()
                        .HasForeignKey("SubGroupID_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Machine_Groups");

                    b.Navigation("Machine_SubGroups");

                    b.Navigation("Models");

                    b.Navigation("Owners");
                });

            modelBuilder.Entity("Maintenance.Models.Machine_SubGroup", b =>
                {
                    b.HasOne("Maintenance.Models.Machine_Group", "Machine_Groups")
                        .WithMany()
                        .HasForeignKey("MachineGroupIDFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Machine_Groups");
                });

            modelBuilder.Entity("Maintenance.Models.Model", b =>
                {
                    b.HasOne("Maintenance.Models.Brand", "Brands")
                        .WithMany()
                        .HasForeignKey("BarndIDFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brands");
                });

            modelBuilder.Entity("Maintenance.Models.User", b =>
                {
                    b.HasOne("Maintenance.Models.Employee", "Employees")
                        .WithMany()
                        .HasForeignKey("EmployeeID_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
