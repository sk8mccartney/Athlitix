namespace Athlitix.Controllers.Requests;

public class EventRequest
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string StartDate { get; set; } = string.Empty;
    public string StartTime { get; set; } = string.Empty;
}
