namespace AdminProvider.Domain.Models;

public class Account
{

    public string Id  = Guid.NewGuid().ToString();
    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;
}
