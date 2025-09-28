using System.ComponentModel.DataAnnotations;

namespace Athlitix.Data.Model;

public class Admin : BaseEntity
{
    [MaxLength(50)]
    public string FirstName { get; set; } = default!;
    [MaxLength(50)]
    public string LastName { get; set; } = default!;
    [MaxLength(254)]
    public string Email { get; set; } = default!;
    [MaxLength(50)]
    public string PhoneNumber { get; set; } = default!;
    [MaxLength(50)]
    public string PasswordHash { get; set; } = default!;
    [MaxLength(50)]
    public string Role { get; set; } = default!;
}
