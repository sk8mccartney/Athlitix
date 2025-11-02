using System.ComponentModel.DataAnnotations;

namespace Athlitix.Entities;

public class CompetitionEntity : BaseEntity
{
    [MaxLength(50)]
    public string Name { get; set; } = default!;

    public string Description { get; set; } = default!;

    public DateTimeOffset StartDate { get; set; }

    public DateTimeOffset FinishDate { get; set; }

    // Foreign key
    public Guid OrganizationId { get; set; }

    public OrganizationEntity Organization { get; set; } = null!;

    public ICollection<EventEntity> Events { get; set; } = new List<EventEntity>();
}