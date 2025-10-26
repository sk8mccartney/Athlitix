using System.ComponentModel.DataAnnotations;

namespace Athlitix.Models;

public class CompetitionModel : BaseModel
{
    public string Name { get; set; } = default!;

    public string Description { get; set; } = default!;

    public DateTimeOffset StartDate { get; set; }

    public DateTimeOffset FinishDate { get; set; }

    public bool IsActive { get; set; }
}
