using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MigrationFix.Models.Zoho;

namespace MigrationFix.Databases.Configurations;

public class LeaveTypeConfiguration : IEntityTypeConfiguration<LeaveType>
{
        public void Configure(EntityTypeBuilder<LeaveType> builder)
        {
            builder.ToTable(nameof(LeaveType));
            builder.HasKey(leaveType => leaveType.Id);
    
            builder.Property(nameof(LeaveType.Name))
                .HasColumnName(nameof(LeaveType.Name));
    
            builder.Property(nameof(LeaveType.Type))
                .HasColumnName(nameof(LeaveType.Type));
    
        }
}
