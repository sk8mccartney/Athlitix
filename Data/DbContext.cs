using Athlitix.Configuration;
using Athlitix.Entities;
using Athlitix.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Athlitix.Data;

public class AthlitixContext : DbContext
{
    public DbSet<OrganizationEntity> Organizations { get; set; }
    public DbSet<AdminEntity> Admins { get; set; }
    public DbSet<CompetitionEntity> Competitions { get; set; }
    public DbSet<EventTypeEntity> EventTypes { get; set; }
    public DbSet<EventEntity> Events { get; set; }
    public DbSet<TeamEntity> Teams { get; set; }
    public DbSet<ParticipantEntity> Participants { get; set; }

    private readonly Guid _organizationId = Guid.Parse("5835ca66-1356-42a5-a36a-cf1a019189f1");
    private readonly Guid _adminId = Guid.Parse("df283585-df16-42d2-aa51-b10eb2861b7e");
    private readonly Guid _competitionId = Guid.Parse("561e6139-413c-4de6-bbdc-6c58bb3b61aa");
    private readonly Guid _eventTypeId1 = Guid.Parse("cac94e39-969d-41ef-9a25-f33675e1fe92");
    private readonly Guid _eventTypeId2 = Guid.Parse("dbc5f1de-fcba-4d0a-8a71-eeb1f209eeff");
    private readonly Guid _eventTypeId3 = Guid.Parse("d9fdad56-2c37-4be7-89ab-1af3cf1142c7");
    private readonly Guid _eventId = Guid.Parse("3f2dbfda-3842-4bd9-a063-00d5fde0c9a0");
    private readonly Guid _teamId1 = Guid.Parse("caccb9c5-7556-47a2-848c-176cee5dc643");
    private readonly Guid _teamId2 = Guid.Parse("0e37b6b5-2a35-4e33-907e-f1c6c0ad7423");
    private readonly Guid _participantId1 = Guid.Parse("7e6db761-6057-427b-afe5-d575f97c00e7");
    private readonly Guid _participantId2 = Guid.Parse("09c7c50f-b897-4586-be37-719fd9d11893");
    private readonly Guid _participantId3 = Guid.Parse("93d6abd2-4651-4a21-9fc5-e9695fc66821");
    private readonly Guid _participantId4 = Guid.Parse("f4e127d6-6af7-43c9-a471-cf944364f892");
    private readonly DateTime _defaultCreatedDate = DateTime.Parse("2025/01/01");
    private readonly string _salt;

    public AthlitixContext(DbContextOptions<AthlitixContext> options, IOptions<SecuritySettings> securityOptions) : base(options)
    {
        _salt = securityOptions.Value.PasswordSalt ?? throw new InvalidOperationException("Missing salt in configuration.");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdminEntity>(entity =>
        {
            entity.ToTable("Admin").HasData(
                new AdminEntity()
                {
                    Id = _adminId,
                    FirstName = "Skate",
                    LastName = "McCartney",
                    PhoneNumber = "01132678544",
                    Email = "skate.mccartney@hotmail.com",
                    PasswordHash = Utility.PasswordHasher.HashPassword("letmein", _salt),
                    Role = AdminRole.Admin.ToString(),
                    OrganizationId = _organizationId,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                });
        });
        modelBuilder.Entity<OrganizationEntity>(entity =>
        {
            entity.ToTable("Organization").HasData(
                new OrganizationEntity()
                {
                    Id = _organizationId,
                    Name = "Elite Muay Thai",
                    Description = "Kicking arse since 2018",
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                });
        });
        modelBuilder.Entity<CompetitionEntity>(entity =>
        {
            entity.ToTable("Competition").HasData(
                new CompetitionEntity()
                {
                    Id = _competitionId,
                    Name = "Legends Final",
                    Description = "Season finaly for all the greatest fighters",
                    StartDate = DateTime.Parse("2026/07/01"),
                    FinishDate = DateTime.Parse("2026/07/02"),
                    OrganizationId = _organizationId,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                });
        });
        modelBuilder.Entity<EventTypeEntity>(entity =>
        {
            entity.ToTable("EventType").HasData(
                new EventTypeEntity()
                {
                    Id = _eventTypeId1,
                    Name = "Skills Bout",
                    Description = "Under 13's non competitive skills fight",
                    OrganizationId = _organizationId,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },
                new EventTypeEntity()
                {
                    Id = _eventTypeId2,
                    Name = "Junior Bout",
                    Description = "Junior competitive skills fight",
                    OrganizationId = _organizationId,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },
                new EventTypeEntity()
                {
                    Id = _eventTypeId3,
                    Name = "Senior Bout",
                    Description = "Senior competitive skills fight",
                    OrganizationId = _organizationId,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                });
        });
        modelBuilder.Entity<EventEntity>(entity =>
        {
            entity.ToTable("Event").HasData(
                new EventEntity()
                {
                    Id = _eventId,
                    Name = "70kg - Skate McCartney vs Abdul Mohadeen",
                    Description = string.Empty,
                    CompetitionId = _competitionId,
                    EventTypeId = _eventTypeId2,
                    StartDate = DateTime.Parse("2026/07/01 19:30:00"),
                    FinishDate = DateTime.Parse("2026/07/01 19:45:00"),
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                });
        });
        modelBuilder.Entity<TeamEntity>(entity =>
        {
            entity.ToTable("Team").HasData(
                new TeamEntity()
                {
                    Id = _teamId1,
                    Name = "LS20 Boxing",
                    Description = "Guisleys premiere boxing club",
                    OrganizationId = _organizationId,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },
                new TeamEntity()
                {
                    Id = _teamId2,
                    Name = "Henrys Boxing",
                    Description = "Guisleys premiere boxing club",
                    OrganizationId = _organizationId,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                });
        });
        modelBuilder.Entity<ParticipantEntity>(entity =>
        {
            entity.ToTable("Participant").HasData(
                new ParticipantEntity() { 
                    Id = _participantId1,
                    FirstName = "Joe",
                    LastName = "McCartney",
                    NickName = "Chunkz",
                    Email = "chunkz@hotmail.com",
                    PhoneNumber = "07470797908",
                    PasswordHash = "",
                    HeightCm = 170m,
                    WeightKg = 65m,
                    DateOfBirth = DateTime.Parse("2008/03/03 00:00:00"),
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                }, new ParticipantEntity()
                {
                    Id = _participantId2,
                    FirstName = "Matthew",
                    LastName = "McCartney",
                    NickName = "Matt",
                    Email = "matt@hotmail.com",
                    PhoneNumber = "07470797908",
                    PasswordHash = "",
                    HeightCm = 173m,
                    WeightKg = 75m,
                    DateOfBirth = DateTime.Parse("1999/04/15 00:00:00"),
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                }, new ParticipantEntity()
                {
                    Id = _participantId3,
                    FirstName = "Elon",
                    LastName = "Musk",
                    NickName = "Moron",
                    Email = "moron@hotmail.com",
                    PhoneNumber = "07470797908",
                    PasswordHash = "",
                    HeightCm = 169m,
                    WeightKg = 66m,
                    DateOfBirth = DateTime.Parse("2001/05/06 00:00:00"),
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                }, new ParticipantEntity()
                {
                    Id = _participantId4,
                    FirstName = "Chuck",
                    LastName = "Norris",
                    NickName = "Chuck",
                    Email = "chuck@hotmail.com",
                    PhoneNumber = "07470797908",
                    PasswordHash = "",
                    HeightCm = 165m,
                    WeightKg = 61m,
                    DateOfBirth = DateTime.Parse("1997/09/28 00:00:00"),
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                });
        });
    }
}