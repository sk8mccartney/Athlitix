using System.ComponentModel.DataAnnotations;

namespace Athlitix.Entities;

public class OrganizationEntity : BaseEntity
{
    [MaxLength(50)]
    public string Name { get; set; } = default!;

    public string Description { get; set; } = default!;

    public ICollection<AdminEntity> Admins { get; set; } = new List<AdminEntity>();

    public ICollection<CompetitionEntity> Competitions { get; set; } = new List<CompetitionEntity>();

    public ICollection<EventTypeEntity> EventTypes { get; set; } = new List<EventTypeEntity>();
}