namespace MigrationFix.Models.Zoho;

public class LeaveType
{
    public Guid Id { get; }
    public string? Name { get; }
    public BillingType Type { get; }
}

public enum BillingType
{
    Paid,
    Unpaid,
}

public enum LeaveDuration
{
    HalfDay,
    FullDay
}
