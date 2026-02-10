using System.ComponentModel.DataAnnotations;

namespace AuthService.Domain.entitis;

public class roles
{
    [key]
    [MaxLength(15)]
    public string Id { get; set; }

    [Required]
    [MaxLength(255)]
    public string Name { get; set; }

    [Required]
    [MaxLength(255)]
    public string Description { get; set; }

    // Realaciones con UserRole
    public ICollection <UserRole> UserRoles { get; set; }

}

/*

+--------------+--------------+------------------+
| Id           | Name         | Description      |
+--------------+--------------+------------------+
| ADMIN        | Admin        | Administrador    |
| USER         | User         | Usuario normal   |
| GUEST        | Guest        | Invitado         |
+--------------+--------------+------------------+

*/