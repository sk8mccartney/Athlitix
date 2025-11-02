namespace Athlitix.Models;

public class EventModel
{
    public string Name { get; set; } = default!;

    public string Description { get; set; } = default!;

    public DateTimeOffset StartDate { get; set; }

    public DateTimeOffset FinishDate { get; set; }
}
