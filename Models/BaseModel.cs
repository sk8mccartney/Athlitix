namespace Athlitix.Models;

public class BaseModel
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public string CreatedBy { get; set; } = default!;
    public DateTime ModifiedAt { get; set; }
    public string ModifiedBy { get; set; } = default!;
}
