using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string UserName { get; set; } = default!;

    public string? PasswordHash { get; set; }

    public string? Email { get; set; }

    public string? LastLoginIP { get; set; }

    public string? Role { get; set; }
}
