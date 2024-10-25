namespace Cerberus.Domain.Employees;

public record Credential
{
    public required string Username { get; set; }
    public required string PasswordHash { get; set; }
    public required string Email { get; set; }
}