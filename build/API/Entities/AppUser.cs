namespace API.Entities;

public class AppUser
{
    // public string Id { get; set; } = "";
    // public required string Id { get; set; }

    public string Id { get; set; } = Guid.NewGuid().ToString();

    public required string DisplayName { get; set; }
    public required string Email { get; set; }
    public required byte[] PasswordHash { get; set; } //one-way encryption
    public required byte[] PasswordSalt { get; set; } //extra layer of security, randomizes password hash
}

