using System.ComponentModel.DataAnnotations;

namespace Athlitix.Entities;

public class TeamEntity : BaseEntity
{
    [MaxLength(50)]
    public string Name { get; set; } = default!;

    public string Description { get; set; } = default!;

    // Foreign key
    public Guid OrganizationId { get; set; }

    public OrganizationEntity Organization { get; set; } = null!;
}
