namespace Athlitix.Models;

public class EventModel : BaseModel
{
    public string Name { get; set; } = default!;

    public string Description { get; set; } = default!;

    public DateTimeOffset StartDate { get; set; }

    public Guid EventTypeId { get; set; }

    public Guid CompetitionId { get; set; }

    public CompetitionModel Competition { get; set; } = default!;
}
