using Microsoft.EntityFrameworkCore;
using MigrationFix.Databases.Configurations;
using MigrationFix.Models.Zoho;

namespace MigrationFix.Databases;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<LeaveType> LeaveTypes { get; set; }
    public DbSet<LeaveRequest> LeaveRequests { get; set; }
    public DbSet<LeaveRequestDays> LeaveRequestDays { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new EmployeeConfiguration().Configure(modelBuilder.Entity<Employee>());
        new LeaveTypeConfiguration().Configure(modelBuilder.Entity<LeaveType>());
        new LeaveRequestConfiguration().Configure(modelBuilder.Entity<LeaveRequest>());
        new LeaveRequestDaysConfiguration().Configure(modelBuilder.Entity<LeaveRequestDays>());
    }
}