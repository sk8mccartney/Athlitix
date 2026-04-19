namespace Athlitix.Controllers.Requests;

// Request that will be sent in json to the event rest (API) endpoint
// Uses native data types, which may be converted later.
// Defaults set incase of ommission
public class EventRequest
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string WeightRange { get; set; } = string.Empty;
    public string StartDate { get; set; } = string.Empty;
    public string StartTime { get; set; } = string.Empty;
    public Guid CompetitionId { get; set; }
    public Guid EventTypeId { get; set; }
}
