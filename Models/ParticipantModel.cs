namespace Athlitix.Models;

public class ParticipantModel : BaseModel
{
    public Guid TeamId { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string NickName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public string PasswordHash { get; set; } = default!;
    public decimal HeightCm { get; set; }
    public decimal WeightKg { get; set; }
    public DateTimeOffset DateOfBirth { get; set; }

    public TeamModel Team { get; set; } = default!;

    public int Age
    {
        get {
            var today = DateTime.Today;
            var age = today.Year - DateOfBirth.Year;

            if (DateOfBirth.Date > today.AddYears(-age))
                age--;

            return age;
        }
        private set { }
    }
}
