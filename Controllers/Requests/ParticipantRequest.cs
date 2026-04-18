namespace Athlitix.Controllers.Requests;

public class ParticipantRequest
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string NickName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string DateOfBirth { get; set; } = string.Empty;
    public string Gender {  get; set; } = string.Empty;
    public bool HasMedicalClearance { get; set; }
    public decimal WeightKg { get; set; }
    public decimal HeightCm { get; set; }
    public string Record { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;
    public Guid TeamId { get; set; }
}
