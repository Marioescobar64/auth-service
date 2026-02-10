using System.ComponentModel.DataAnnotations;

namespace AuthService.Domain.entitis;

public class UserProfile
{
    [Key]
    [MaxLength(15)]
    public string Id { get; set; } = string.Empty;
    
    [Required]
    [MaxLength(16)]
    [ForeignKey(nameof(User))]
    public string UserId { get; set; } = string.Empty;

    public string ProfilePictureUrl { get; set; }

    public string Bio { get; set;}

    public DateTime DateOfBitrh { get; set; }

    public User User { get; set;} = null!;




}