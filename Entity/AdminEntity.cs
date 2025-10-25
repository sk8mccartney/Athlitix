using System.ComponentModel.DataAnnotations;

namespace Athlitix.Models;

public class AdminEntity : BaseEntity
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
    public string Role { get; set; } = AdminRole.Readonly.ToString();
    public bool IsActive { get; set; }

    // Foreign key
    public Guid OrganizationId { get; set; }
    public OrganizationEntity Organization { get; set; } = null!;
}

