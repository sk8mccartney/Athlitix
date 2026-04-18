using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Athlitix.Entities;

public class ParticipantEntity : BaseEntity
{
    [MaxLength(50)]
    public string FirstName { get; set; } = default!;

    [MaxLength(50)]
    public string LastName { get; set; } = default!;

    [MaxLength(50)]
    public string NickName { get; set; } = default!;

    [MaxLength(256)]
    public string Email { get; set; } = default!;

    [MaxLength(50)]
    public string PhoneNumber { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;

    [Precision(4, 1)]
    public decimal HeightCm { get; set; }

    [Precision(4, 1)]
    public decimal WeightKg { get; set; }

    public DateTimeOffset DateOfBirth { get; set; }
    public string Gender { get; set; } = Utilities.Gender.Male.ToString();
    public bool HasMedicalClearance { get; set; }
    public string Record { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;

    // Foreign key
    public Guid TeamId { get; set; }

    public TeamEntity Team { get; set; } = null!;
}