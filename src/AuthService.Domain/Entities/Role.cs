using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AuthService.Domain.Enums;

namespace AuthService.Domain.Entities;

public class Role
{
    [Key]
    [MaxLength(16)]
    public string Id { get; set;}

    [Required]
    [MaxLength(50)]
    public string Name { get; set;}

    [Required]
    [MaxLength(255)]
    public string Description { get; set;}

    // Relaciones con UserRole
    public ICollection<UserRole> UserRoles { get; set;}
}

/*
Vista de la tabla a modo SQL
Roles
+--------------+--------------+------------------+
| Id           | Name         | Description      |
+--------------+--------------+------------------+
| ADMIN        | Admin        | Administrador    |
| USER         | User         | Usuario normal   |
| GUEST        | Guest        | Invitado         |
+--------------+--------------+------------------+
*/
