using Microsoft.EntityFrameworkCore;
using Maintenance.Models;
using System.Data;


namespace Maintenance.Data
{
    public class MaintenanceDbContext : DbContext
    {
        public MaintenanceDbContext(DbContextOptions<MaintenanceDbContext> options) : base(options)
        {

        }


        ////    protected override void OnModelCreating(ModelBuilder modelBuilder)
        ////    {
        ////        base.OnModelCreating(modelBuilder);
        ////        modelBuilder.Entity<Category_Course>().HasNoKey().ToSqlQuery("category_Courses");
        ////    }

        public DbSet<Brand_Group> Brand_Groups { get; set; }
        public DbSet<Brand_SubGroup> Brand_SubGroups { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Machine> Machines { get; set; }
        public DbSet<Machine_Movement> Machine_Movements { get; set; }
        public DbSet<Movement_Type> Movement_Types { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Work_Type> Work_Types { get; set; }
      
        public DbSet<Item_Group> Item_Groups { get; set; }
        public DbSet<Item_SubGroup> Item_SubGroups { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Profession> Professions { get; set; }






    }

}
