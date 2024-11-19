namespace MigrationFix.Models.Zoho;

public class LeaveRequestDays
{
    public Guid Id { get; set; }
    public DateOnly Date { get; set; }
    public LeaveDuration Duration { get; set; }
    public TimeSlot TimeSlot { get; set; }

    public decimal LeaveDaysNumber => Duration switch
    {
        LeaveDuration.HalfDay => 0.5m,
        LeaveDuration.FullDay => 1,
        _ => throw new InvalidOperationException()
    };
}

public class TimeSlot
{
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set;  }
}