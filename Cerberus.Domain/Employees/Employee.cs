namespace Cerberus.Domain.Employees;

public class Employee
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } =string.Empty;
    public string LastName { get; set; } = string.Empty;
   public  Credential? Credential { get; set; }
    public string Phone { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public DateTime Birthday { get; set; }
    public string Gender { get; set; } = string.Empty;
    public string JobTitle { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    
}