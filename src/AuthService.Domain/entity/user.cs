using System.ComponentModel.DataAnnotations;

namespace AuthService.Domain.entitis;

public class User
{
    [key]
    [MaxLength(15)]
    public string Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio")]
    [MaxLength(25)]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "El nombre es obligatorio")]
    [MaxLength(25)]
    public string Surname { get; set; } = string.Empty;

    [Required(ErrorMessage = "El Apellido es obligatorio")]
    [MaxLength(25)]
    public string Username { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    [MaxLength(255)]
    public string Password { get; set; } = string.Empty;

    public bool Status { get; set; } = true;

    [Required]
    public DateTime CreateAt { get; set; } 

    [Required]
    public DateTime UpdatedAt { get; set; }

    [Required]
    public UserProfile UserProfile { get; set; } = null!;
    public ICollection<UserRole> UserRoles { get; set; } = [];
    public UserEmail UserEmail { get; set; } = null!;
    public UserPasswordResert PasswordResert { get; set; } = null!;

}
