namespace Athlitix.Controllers.Requests;

// Request that will be sent in json to the team rest (API) endpoint
// Uses native data types, which may be converted later.
// Defaults set incase of ommission
public class TeamRequest
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Guid OrganizationId { get; set; }
}
