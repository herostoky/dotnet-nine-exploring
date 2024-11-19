namespace MigrationFix.Models.Zoho;

public class Employee
{
    public Guid Id { get; set; }
    public string? FullName { get; set; }

    public string? CustomFieldsValue { get; set;  }
}
