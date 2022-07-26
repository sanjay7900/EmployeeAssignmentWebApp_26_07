using EmployeeAssignment_26_07_WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAssignment_26_07_WebApp
{
    public class WebAppDbContext:DbContext
    {
        public DbSet<Employee> Employee { set; get; }
        public  WebAppDbContext() { }
        public WebAppDbContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder option)
        {
            option.UseSqlServer(@"Data Source=DESKTOP-AMR2CQS\MSSQLSERVER01;Initial Catalog=EmployeeAssignmentWebApp;Integrated Security=True");

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>().HasIndex(Emp => Emp.Email).IsUnique();
            

        }

    }
}
