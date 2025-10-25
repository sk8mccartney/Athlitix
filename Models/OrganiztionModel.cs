namespace Athlitix.Models;

public class OrganizationModel : BaseModel
{
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public bool IsActive { get; set; }
}
