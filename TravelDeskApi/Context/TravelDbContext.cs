using Microsoft.EntityFrameworkCore;
using TravelDeskApi.Models;

namespace TravelDeskApi.Context
{
    public class TravelDbContext : DbContext
    {
        public TravelDbContext()
        {

        }

        public TravelDbContext(DbContextOptions<TravelDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Project> Projects { get; set; }
        
        public DbSet<TravelRequest> TravelRequests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                 new Role() {  RoleId=1, RoleName="Admin"},
                  new Role() { RoleId = 2, RoleName = "TravelAdmin" },
                   new Role() { RoleId = 3, RoleName = "Manager" },
                    new Role() { RoleId = 4, RoleName = "Employee" }

           );

            modelBuilder.Entity<Department>().HasData(
                new Department() { DepartmentId = 1, DepartmentName = "Accts" },
                new  Department() { DepartmentId = 2, DepartmentName = "HR" },
                new Department() { DepartmentId = 3, DepartmentName = "IT" }

                );
   modelBuilder.Entity<Project>().HasData(
       
                new Project() { ProjectId=1, ProjectName="ABC Project" },
                new Project() { ProjectId = 2, ProjectName = "XYZ Project" },
                new Project() { ProjectId = 3, ProjectName = "ABd Project" }

            
            );

        }
    }
}
