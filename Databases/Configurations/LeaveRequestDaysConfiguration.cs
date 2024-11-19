//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationFix.Databases.Configurations;

public class LeaveRequestDaysConfiguration// : IEntityTypeConfiguration<LeaveRequestDays>
{
    //    public void Configure(EntityTypeBuilder<LeaveRequestDays> builder)
    //    {
    //            builder.ToTable(nameof(LeaveRequestDays));
    //            builder.HasKey(leaveRequestDays => leaveRequestDays.Id);
    //
    //            builder.Property(leaveRequestDays => leaveRequestDays.Date)
    //                .HasColumnName(nameof(LeaveRequestDays.Date))
    //                .IsRequired();
    //
    //            builder.Property(leaveRequestDays => leaveRequestDays.Duration)
    //                .HasColumnName(nameof(LeaveRequestDays.Duration))
    //                .HasConversion<string>()
    //                .IsRequired();
    //
    //            builder.OwnsOne(leaveRequestDays => leaveRequestDays.TimeSlot, timeSlot =>
    //            {
    //                timeSlot.Property(t => t.StartTime)
    //                    .HasColumnName(nameof(TimeSlot.StartTime))
    //                    .IsRequired();
    //
    //                timeSlot.Property(t => t.EndTime)
    //                    .HasColumnName(nameof(TimeSlot.EndTime))
    //                    .IsRequired();
    //            });
    //    }
}
