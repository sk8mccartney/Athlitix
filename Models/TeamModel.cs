namespace Athlitix.Models;

public class TeamModel : BaseModel
{
    public string Name { get; set; } = default!;

    public string Description { get; set; } = default!;

    public int ParticipantCount { get; set; }
}
