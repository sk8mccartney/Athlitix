namespace Athlitix.Models;

public class AdminModel : BaseModel
{
    public Guid OrganizationId { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public string Role { get; set; } = default!;
    public bool IsActive { get; set; }
}
