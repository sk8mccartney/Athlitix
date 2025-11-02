using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations;

namespace Athlitix.Entities;

public class EventEntity : BaseEntity
{
    [MaxLength(50)]
    public string Name { get; set; } = default!;

    public string Description { get; set; } = default!;

    public DateTimeOffset StartDate { get; set; }

    public DateTimeOffset FinishDate { get; set; }
    public Guid EventTypeId { get; set; }


    // Foreign key
    public Guid CompetitionId { get; set; }

    public CompetitionEntity Competition { get; set; } = null!;
}