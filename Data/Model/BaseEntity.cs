using System.ComponentModel.DataAnnotations;

namespace Athlitix.Data.Model;

public class BaseEntity
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    [MaxLength(254)]
    public string CreatedBy { get; set; } = default!;
    public DateTime ModifiedAt { get; set; }
    [MaxLength(254)]
    public string ModifiedBy { get; set; } = default!;
}
