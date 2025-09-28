using System.ComponentModel.DataAnnotations;

namespace Athlitix.Services.Models;

public class AdminModel : BaseModel
{
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public string Role { get; set; } = default!;
}
