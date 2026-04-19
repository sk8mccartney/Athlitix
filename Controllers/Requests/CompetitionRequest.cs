namespace Athlitix.Controllers.Requests;

// Request that will be sent in json to the competition rest (API) endpoint
// Uses native data types, which may be converted later.
// Defaults set incase of ommission
public class CompetitionRequest
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string StartDate { get; set; } = string.Empty;
    public string StartTime { get; set; } = string.Empty;
    public string TeamId { get; set; } = string.Empty;
    public Guid OrganizationId { get; set; }
}
