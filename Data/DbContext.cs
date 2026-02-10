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
    private readonly Guid _competitionId1 = Guid.Parse("561e6139-413c-4de6-bbdc-6c58bb3b61aa");
    private readonly Guid _competitionId2 = Guid.Parse("8f3a2c1b-4d7e-4a9f-8b2d-1c0e9f7a6b5d");
    private readonly Guid _competitionId3 = Guid.Parse("d4e7a1b2-3c8f-4d5a-9e7b-2f1c0a8d9e6b");
    private readonly Guid _eventTypeId1 = Guid.Parse("cac94e39-969d-41ef-9a25-f33675e1fe92");
    private readonly Guid _eventTypeId2 = Guid.Parse("dbc5f1de-fcba-4d0a-8a71-eeb1f209eeff");
    private readonly Guid _eventTypeId3 = Guid.Parse("d9fdad56-2c37-4be7-89ab-1af3cf1142c7");
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
                    Id = _competitionId1,
                    Name = "Legends Final",
                    Description = "Season finaly for all the greatest fighters",
                    StartDate = DateTime.Parse("2026/07/01"),
                    FinishDate = DateTime.Parse("2026/07/02"),
                    OrganizationId = _organizationId,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },
                new CompetitionEntity()
                {
                    Id = _competitionId2,
                    Name = "Summer Showdown",
                    Description = "A thrilling summer event bringing together top amateurs for fast-paced bouts.",
                    StartDate = DateTime.Parse("2026/07/30"),
                    FinishDate = DateTime.Parse("2026/07/31"),
                    OrganizationId = _organizationId,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },
                new CompetitionEntity()
                {
                    Id = _competitionId3,
                    Name = "August Clash",
                    Description = "Kicking off August with fierce matchups across all weight categories.",
                    StartDate = DateTime.Parse("2026/08/01"),
                    FinishDate = DateTime.Parse("2026/08/02"),
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
                new EventEntity
                {
                    Id = Guid.Parse("101a7f3c-9c2b-4f1a-9e3d-6c5a4b3d2e01"),
                    Name = "Men's Under 60kg Open",
                    Description = "Men's amateur lightweight division (Under 60kg).",
                    StartDate = new DateTimeOffset(2026, 7, 7, 20, 0, 0, TimeSpan.Zero),
                    FinishDate = new DateTimeOffset(2026, 7, 7, 20, 15, 0, TimeSpan.Zero),
                    EventTypeId = _eventTypeId2,
                    CompetitionId = _competitionId1,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },

                new EventEntity
                {
                    Id = Guid.Parse("202b8e4d-1a3c-4b2d-8f9e-7d6c5b4a3e02"),
                    Name = "Men's Under 71kg Open",
                    Description = "Men's amateur light-middleweight division (Under 71kg).",
                    StartDate = new DateTimeOffset(2026, 7, 7, 20, 15, 0, TimeSpan.Zero),
                    FinishDate = new DateTimeOffset(2026, 7, 7, 20, 30, 0, TimeSpan.Zero),
                    EventTypeId = _eventTypeId3,
                    CompetitionId = _competitionId1,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },

                new EventEntity
                {
                    Id = Guid.Parse("303c9d5e-2b4d-4c3e-9a8f-8e7d6c5b4a03"),
                    Name = "Men's Under 54kg Open",
                    Description = "Men's amateur bantamweight division (Under 54kg).",
                    StartDate = new DateTimeOffset(2026, 7, 7, 20, 30, 0, TimeSpan.Zero),
                    FinishDate = new DateTimeOffset(2026, 7, 7, 20, 45, 0, TimeSpan.Zero),
                    EventTypeId = _eventTypeId2,
                    CompetitionId = _competitionId1,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },

                new EventEntity
                {
                    Id = Guid.Parse("404d0c6f-3c5e-4d4f-8b7a-9f8e7d6c5b04"),
                    Name = "Men's Under 80kg Open",
                    Description = "Men's amateur light-heavyweight division (Under 80kg).",
                    StartDate = new DateTimeOffset(2026, 7, 7, 20, 45, 0, TimeSpan.Zero),
                    FinishDate = new DateTimeOffset(2026, 7, 7, 21, 0, 0, TimeSpan.Zero),
                    EventTypeId = _eventTypeId3,
                    CompetitionId = _competitionId1,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },

                new EventEntity
                {
                    Id = Guid.Parse("505e1b7a-4d6f-4e5a-9c8b-0a9f8e7d6c05"),
                    Name = "Men's Under 63.5kg Open",
                    Description = "Men's amateur light-welterweight division (Under 63.5kg).",
                    StartDate = new DateTimeOffset(2026, 7, 7, 21, 0, 0, TimeSpan.Zero),
                    FinishDate = new DateTimeOffset(2026, 7, 7, 21, 15, 0, TimeSpan.Zero),
                    EventTypeId = _eventTypeId2,
                    CompetitionId = _competitionId1,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },

                new EventEntity
                {
                    Id = Guid.Parse("606f2a8b-5e7a-4f6b-8d9c-1b0a9f8e7d06"),
                    Name = "Men's Under 92kg Open",
                    Description = "Men's amateur heavyweight division (Under 92kg).",
                    StartDate = new DateTimeOffset(2026, 7, 7, 21, 15, 0, TimeSpan.Zero),
                    FinishDate = new DateTimeOffset(2026, 7, 7, 21, 30, 0, TimeSpan.Zero),
                    EventTypeId = _eventTypeId3,
                    CompetitionId = _competitionId1,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },

                new EventEntity
                {
                    Id = Guid.Parse("707a3b9c-6f8b-4a7c-9e0d-2c1b0a9f8e07"),
                    Name = "Men's Under 57kg Open",
                    Description = "Men's amateur featherweight division (Under 57kg).",
                    StartDate = new DateTimeOffset(2026, 7, 7, 21, 30, 0, TimeSpan.Zero),
                    FinishDate = new DateTimeOffset(2026, 7, 7, 21, 45, 0, TimeSpan.Zero),
                    EventTypeId = _eventTypeId2,
                    CompetitionId = _competitionId1,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },

                new EventEntity
                {
                    Id = Guid.Parse("808b4cad-7a9c-4b8d-8f1e-3d2c1b0a9f08"),
                    Name = "Men's Over 92kg Open",
                    Description = "Men's amateur super-heavyweight division (Over 92kg).",
                    StartDate = new DateTimeOffset(2026, 7, 7, 21, 45, 0, TimeSpan.Zero),
                    FinishDate = new DateTimeOffset(2026, 7, 7, 22, 0, 0, TimeSpan.Zero),
                    EventTypeId = _eventTypeId3,
                    CompetitionId = _competitionId1,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                });
        });
        modelBuilder.Entity<TeamEntity>(entity =>
        {
            entity.ToTable("Team").HasData(
                new TeamEntity()
                {
                    Id = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"),
                    Name = "LS1 Leeds Lions",
                    Description = "Fearless fighters roaring out of central Leeds",
                    OrganizationId = _organizationId,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },

                new TeamEntity()
                {
                    Id = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0002"),
                    Name = "M1 Manchester Maulers",
                    Description = "Grit-fueled brawlers built for pressure fights",
                    OrganizationId = _organizationId,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },

                new TeamEntity()
                {
                    Id = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"),
                    Name = "S6 Sheffield Steel",
                    Description = "Forged tough with relentless knockout power",
                    OrganizationId = _organizationId,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },

                new TeamEntity()
                {
                    Id = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"),
                    Name = "L2 Liverpool Legends",
                    Description = "Fast-handed fighters with championship ambition",
                    OrganizationId = _organizationId,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },

                new TeamEntity()
                {
                    Id = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"),
                    Name = "NE1 Newcastle Nightfall",
                    Description = "Late-round warriors with ruthless finishes",
                    OrganizationId = _organizationId,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },

                new TeamEntity()
                {
                    Id = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"),
                    Name = "B1 Birmingham Brutes",
                    Description = "Midlands muscle with heavy-hitting intent",
                    OrganizationId = _organizationId,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },

                new TeamEntity()
                {
                    Id = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"),
                    Name = "NG1 Nottingham Knockout",
                    Description = "Precision punchers with outlaw mentality",
                    OrganizationId = _organizationId,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },

                new TeamEntity()
                {
                    Id = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0008"),
                    Name = "LE1 Leicester Lightning",
                    Description = "Explosive speed and high-volume attacks",
                    OrganizationId = _organizationId,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },

                new TeamEntity()
                {
                    Id = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"),
                    Name = "CV1 Coventry Crushers",
                    Description = "Breakdown specialists who wear opponents out",
                    OrganizationId = _organizationId,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },

                new TeamEntity()
                {
                    Id = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0010"),
                    Name = "DE1 Derby Dominators",
                    Description = "Ring control experts with suffocating pressure",
                    OrganizationId = _organizationId,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },

                new TeamEntity()
                {
                    Id = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0011"),
                    Name = "EC1 London Empire",
                    Description = "Elite-level fighters chasing national dominance",
                    OrganizationId = _organizationId,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },

                new TeamEntity()
                {
                    Id = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"),
                    Name = "BN1 Brighton Breakers",
                    Description = "Smooth operators with sudden knockout power",
                    OrganizationId = _organizationId,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },

                new TeamEntity()
                {
                    Id = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"),
                    Name = "SO14 Southampton Strikers",
                    Description = "Sharp-shooting south coast contenders",
                    OrganizationId = _organizationId,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },

                new TeamEntity()
                {
                    Id = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"),
                    Name = "PO1 Portsmouth Punishers",
                    Description = "Hard-nosed fighters with navy-town toughness",
                    OrganizationId = _organizationId,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },

                new TeamEntity()
                {
                    Id = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"),
                    Name = "GU1 Guildford Gladiators",
                    Description = "Modern warriors with old-school grit",
                    OrganizationId = _organizationId,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },

                new TeamEntity()
                {
                    Id = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"),
                    Name = "CB1 Cambridge Combat",
                    Description = "Smart, technical fighters with killer instinct",
                    OrganizationId = _organizationId,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },

                new TeamEntity()
                {
                    Id = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0017"),
                    Name = "BS1 Bristol Brawlers",
                    Description = "Street-bred toughness with pro-level skill",
                    OrganizationId = _organizationId,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },

                new TeamEntity()
                {
                    Id = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0018"),
                    Name = "EX1 Exeter Enforcers",
                    Description = "Southern grit with relentless pressure style",
                    OrganizationId = _organizationId,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },

                new TeamEntity()
                {
                    Id = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0019"),
                    Name = "PL1 Plymouth Power",
                    Description = "Tidal-force punchers from the southwest",
                    OrganizationId = _organizationId,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },

                new TeamEntity()
                {
                    Id = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0020"),
                    Name = "OX1 Oxford Overlords",
                    Description = "Calculated destruction with elite ring IQ",
                    OrganizationId = _organizationId,
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                });
        });
        modelBuilder.Entity<ParticipantEntity>(entity =>
        {
            entity.ToTable("Participant").HasData(
                new ParticipantEntity()
                {
                    Id = Guid.Parse("b1000001-1111-4111-8111-111111111001"),
                    FirstName = "Jack",
                    LastName = "Smith",
                    NickName = "Tank",
                    Email = "jack.smith1@example.com",
                    PhoneNumber = "07470000001",
                    PasswordHash = "",
                    HeightCm = 172m,
                    WeightKg = 67m,
                    DateOfBirth = DateTime.Parse("2006/05/12 00:00:00"),
                    TeamId = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), // LS20 Boxing
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },
                new ParticipantEntity()
                {
                    Id = Guid.Parse("b1000002-1111-4111-8111-111111111002"),
                    FirstName = "Tom",
                    LastName = "Jones",
                    NickName = "Flash",
                    Email = "tom.jones2@example.com",
                    PhoneNumber = "07470000002",
                    PasswordHash = "",
                    HeightCm = 178m,
                    WeightKg = 71m,
                    DateOfBirth = DateTime.Parse("2005/09/03 00:00:00"),
                    TeamId = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), // Henrys Boxing
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },
                new ParticipantEntity()
                {
                    Id = Guid.Parse("b1000003-1111-4111-8111-111111111003"),
                    FirstName = "Harry",
                    LastName = "Brown",
                    NickName = "Hammer",
                    Email = "harry.brown3@example.com",
                    PhoneNumber = "07470000003",
                    PasswordHash = "",
                    HeightCm = 180m,
                    WeightKg = 75m,
                    DateOfBirth = DateTime.Parse("2004/11/21 00:00:00"),
                    TeamId = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0001"), // LS1 Leeds Lions
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },
                new ParticipantEntity()
                {
                    Id = Guid.Parse("b1000004-1111-4111-8111-111111111004"),
                    FirstName = "Liam",
                    LastName = "Taylor",
                    NickName = "Ace",
                    Email = "liam.taylor4@example.com",
                    PhoneNumber = "07470000004",
                    PasswordHash = "",
                    HeightCm = 175m,
                    WeightKg = 63.5m,
                    DateOfBirth = DateTime.Parse("2007/02/10 00:00:00"),
                    TeamId = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0002"), // M1 Manchester Maulers
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },
                new ParticipantEntity()
                {
                    Id = Guid.Parse("b1000005-1111-4111-8111-111111111005"),
                    FirstName = "Josh",
                    LastName = "Wilson",
                    NickName = "Crusher",
                    Email = "josh.wilson5@example.com",
                    PhoneNumber = "07470000005",
                    PasswordHash = "",
                    HeightCm = 182m,
                    WeightKg = 80m,
                    DateOfBirth = DateTime.Parse("2003/07/18 00:00:00"),
                    TeamId = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0003"), // S6 Sheffield Steel
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },
                new ParticipantEntity()
                {
                    Id = Guid.Parse("b1000006-1111-4111-8111-111111111006"),
                    FirstName = "Ben",
                    LastName = "Walker",
                    NickName = "Spike",
                    Email = "ben.walker6@example.com",
                    PhoneNumber = "07470000006",
                    PasswordHash = "",
                    HeightCm = 170m,
                    WeightKg = 60m,
                    DateOfBirth = DateTime.Parse("2008/01/30 00:00:00"),
                    TeamId = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0004"), // L2 Liverpool Legends
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },
                new ParticipantEntity()
                {
                    Id = Guid.Parse("b1000007-1111-4111-8111-111111111007"),
                    FirstName = "Sam",
                    LastName = "White",
                    NickName = "Storm",
                    Email = "sam.white7@example.com",
                    PhoneNumber = "07470000007",
                    PasswordHash = "",
                    HeightCm = 176m,
                    WeightKg = 67m,
                    DateOfBirth = DateTime.Parse("2006/06/14 00:00:00"),
                    TeamId = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0005"), // NE1 Newcastle Nightfall
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },
                new ParticipantEntity()
                {
                    Id = Guid.Parse("b1000008-1111-4111-8111-111111111008"),
                    FirstName = "Ryan",
                    LastName = "Hall",
                    NickName = "Blade",
                    Email = "ryan.hall8@example.com",
                    PhoneNumber = "07470000008",
                    PasswordHash = "",
                    HeightCm = 185m,
                    WeightKg = 85m,
                    DateOfBirth = DateTime.Parse("2002/10/05 00:00:00"),
                    TeamId = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0006"), // B1 Birmingham Brutes
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },
                new ParticipantEntity()
                {
                    Id = Guid.Parse("b1000009-1111-4111-8111-111111111009"),
                    FirstName = "Luke",
                    LastName = "Turner",
                    NickName = "Beast",
                    Email = "luke.turner9@example.com",
                    PhoneNumber = "07470000009",
                    PasswordHash = "",
                    HeightCm = 179m,
                    WeightKg = 75m,
                    DateOfBirth = DateTime.Parse("2004/04/19 00:00:00"),
                    TeamId = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0007"), // NG1 Nottingham Knockout
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },
                new ParticipantEntity()
                {
                    Id = Guid.Parse("b1000010-1111-4111-8111-111111111010"),
                    FirstName = "Callum",
                    LastName = "Harris",
                    NickName = "Bulldog",
                    Email = "callum.harris10@example.com",
                    PhoneNumber = "07470000010",
                    PasswordHash = "",
                    HeightCm = 183m,
                    WeightKg = 90m,
                    DateOfBirth = DateTime.Parse("2001/12/01 00:00:00"),
                    TeamId = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0008"), // LE1 Leicester Lightning
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },
                new ParticipantEntity()
                {
                    Id = Guid.Parse("b1000011-1111-4111-8111-111111111011"),
                    FirstName = "Jake",
                    LastName = "Roberts",
                    NickName = "Rocket",
                    Email = "jake.roberts11@example.com",
                    PhoneNumber = "07470000011",
                    PasswordHash = "",
                    HeightCm = 174m,
                    WeightKg = 63.5m,
                    DateOfBirth = DateTime.Parse("2007/03/08 00:00:00"),
                    TeamId = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0009"), // CV1 Coventry Crushers
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },
                new ParticipantEntity()
                {
                    Id = Guid.Parse("b1000012-1111-4111-8111-111111111012"),
                    FirstName = "Connor",
                    LastName = "Clarke",
                    NickName = "Iron",
                    Email = "connor.clarke12@example.com",
                    PhoneNumber = "07470000012",
                    PasswordHash = "",
                    HeightCm = 181m,
                    WeightKg = 75m,
                    DateOfBirth = DateTime.Parse("2004/08/22 00:00:00"),
                    TeamId = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0010"), // DE1 Derby Dominators
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },
                new ParticipantEntity()
                {
                    Id = Guid.Parse("b1000013-1111-4111-8111-111111111013"),
                    FirstName = "Dan",
                    LastName = "Wood",
                    NickName = "Knuckles",
                    Email = "dan.wood13@example.com",
                    PhoneNumber = "07470000013",
                    PasswordHash = "",
                    HeightCm = 177m,
                    WeightKg = 71m,
                    DateOfBirth = DateTime.Parse("2005/01/14 00:00:00"),
                    TeamId = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0011"), // EC1 London Empire
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },
                new ParticipantEntity()
                {
                    Id = Guid.Parse("b1000014-1111-4111-8111-111111111014"),
                    FirstName = "Alex",
                    LastName = "Thompson",
                    NickName = "Shadow",
                    Email = "alex.thompson14@example.com",
                    PhoneNumber = "07470000014",
                    PasswordHash = "",
                    HeightCm = 184m,
                    WeightKg = 85m,
                    DateOfBirth = DateTime.Parse("2002/06/30 00:00:00"),
                    TeamId = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0012"), // BN1 Brighton Breakers
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },
                new ParticipantEntity()
                {
                    Id = Guid.Parse("b1000015-1111-4111-8111-111111111015"),
                    FirstName = "Max",
                    LastName = "Jackson",
                    NickName = "Hammer",
                    Email = "max.jackson15@example.com",
                    PhoneNumber = "07470000015",
                    PasswordHash = "",
                    HeightCm = 179m,
                    WeightKg = 80m,
                    DateOfBirth = DateTime.Parse("2003/09/11 00:00:00"),
                    TeamId = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0013"), // SO14 Southampton Strikers
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },
                new ParticipantEntity()
                {
                    Id = Guid.Parse("b1000016-1111-4111-8111-111111111016"),
                    FirstName = "Ollie",
                    LastName = "Turner",
                    NickName = "Flash",
                    Email = "ollie.turner16@example.com",
                    PhoneNumber = "07470000016",
                    PasswordHash = "",
                    HeightCm = 171m,
                    WeightKg = 60m,
                    DateOfBirth = DateTime.Parse("2008/04/02 00:00:00"),
                    TeamId = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0014"), // PO1 Portsmouth Punishers
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },
                new ParticipantEntity()
                {
                    Id = Guid.Parse("b1000017-1111-4111-8111-111111111017"),
                    FirstName = "Charlie",
                    LastName = "Wright",
                    NickName = "Ace",
                    Email = "charlie.wright17@example.com",
                    PhoneNumber = "07470000017",
                    PasswordHash = "",
                    HeightCm = 176m,
                    WeightKg = 67m,
                    DateOfBirth = DateTime.Parse("2006/11/19 00:00:00"),
                    TeamId = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0015"), // GU1 Guildford Gladiators
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },
                new ParticipantEntity()
                {
                    Id = Guid.Parse("b1000018-1111-4111-8111-111111111018"),
                    FirstName = "Theo",
                    LastName = "Patel",
                    NickName = "Storm",
                    Email = "theo.patel18@example.com",
                    PhoneNumber = "07470000018",
                    PasswordHash = "",
                    HeightCm = 182m,
                    WeightKg = 75m,
                    DateOfBirth = DateTime.Parse("2004/02/27 00:00:00"),
                    TeamId = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0016"), // CB1 Cambridge Combat
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },
                new ParticipantEntity()
                {
                    Id = Guid.Parse("b1000019-1111-4111-8111-111111111019"),
                    FirstName = "Ethan",
                    LastName = "Davies",
                    NickName = "Bulldog",
                    Email = "ethan.davies19@example.com",
                    PhoneNumber = "07470000019",
                    PasswordHash = "",
                    HeightCm = 186m,
                    WeightKg = 90m,
                    DateOfBirth = DateTime.Parse("2001/05/06 00:00:00"),
                    TeamId = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0017"), // BS1 Bristol Brawlers
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                },
                new ParticipantEntity()
                {
                    Id = Guid.Parse("b1000020-1111-4111-8111-111111111020"),
                    FirstName = "Ryan",
                    LastName = "Green",
                    NickName = "Beast",
                    Email = "ryan.green20@example.com",
                    PhoneNumber = "07470000020",
                    PasswordHash = "",
                    HeightCm = 188m,
                    WeightKg = 100m,
                    DateOfBirth = DateTime.Parse("1999/12/17 00:00:00"),
                    TeamId = Guid.Parse("a1c3b6c2-4d5f-4c2a-9a01-1f7b1c9a0018"), //
                    IsActive = true,
                    CreatedAt = _defaultCreatedDate
                });
        });
    }
}