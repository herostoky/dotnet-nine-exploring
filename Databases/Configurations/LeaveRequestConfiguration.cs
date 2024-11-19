using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MigrationFix.Models.Zoho;

namespace MigrationFix.Databases.Configurations;

public class LeaveRequestConfiguration : IEntityTypeConfiguration<LeaveRequest>
{
        public void Configure(EntityTypeBuilder<LeaveRequest> builder)
        {
            builder.ToTable(nameof(LeaveRequest));
            builder.HasKey(leaveRequest => leaveRequest.Id);
    
            builder.Property(leaveRequest => leaveRequest.CreateDateTime)
                .HasColumnName(nameof(LeaveRequest.CreateDateTime))
                .IsRequired();
    
            builder.Property(leaveRequest => leaveRequest.ApprovalStatus)
                .HasColumnName(nameof(LeaveRequest.ApprovalStatus))
                .HasConversion<string>()
                .IsRequired();
    
            builder.OwnsOne(leaveRequest => leaveRequest.LeaveDate, interval =>
            {
                interval.Property(d => d.From)
                    .HasColumnName(nameof(DateInterval.From))
                    .IsRequired();
    
                interval.Property(d => d.To)
                    .HasColumnName(nameof(DateInterval.To))
                    .IsRequired();
            });
    
            builder.HasMany(leaveRequest => leaveRequest.LeaveDays)
                .WithOne()
                .HasForeignKey("_leaveRequestId")
                .OnDelete(DeleteBehavior.Cascade);
    
            builder.HasOne(leaveRequest => leaveRequest.Employee)
                .WithMany()
                .HasForeignKey("_employeeId");
    
            builder.HasOne(leaveRequest => leaveRequest.LeaveType)
                .WithMany()
                .HasForeignKey("_leaveTypeId");
        }
}
