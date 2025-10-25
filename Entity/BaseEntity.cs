using System.ComponentModel.DataAnnotations;

namespace Athlitix.Models;

public class BaseEntity
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    [MaxLength(254)]
    public string? CreatedBy { get; set; }

    public DateTime? ModifiedAt { get; set; }

    [MaxLength(254)]
    public string? ModifiedBy { get; set; }
}