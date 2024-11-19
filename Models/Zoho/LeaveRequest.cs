namespace MigrationFix.Models.Zoho;

public class LeaveRequest
{
    public Guid Id { get; set; }
    public Employee Employee { get; set; }
    public LeaveType LeaveType { get; set; }
    public DateTime CreateDateTime { get; set; }
    public DateInterval LeaveDate { get; set; }
    public decimal LeaveDaysNumber => LeaveDays.Sum(leaveDay => leaveDay.LeaveDaysNumber);
    public LeaveApprovalStatus ApprovalStatus { get; set; }
    public List<LeaveRequestDays> LeaveDays { get; set; } = new List<LeaveRequestDays>();
    public IReadOnlyList<LeaveRequestDays> LeaveRequestDays => LeaveDays.AsReadOnly();
}

public enum LeaveApprovalStatus
{
    Approved, Pending, Cancelled, Rejected
}

public class DateInterval
{
    public DateOnly From { get; set; }
    public DateOnly To { get; set; }
}