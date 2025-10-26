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

    private readonly Guid _organizationId = Guid.Parse("5835ca66-1356-42a5-a36a-cf1a019189f1");
    private readonly Guid _adminId = Guid.Parse("df283585-df16-42d2-aa51-b10eb2861b7e");
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
                    CreatedAt = DateTime.Parse("2025/01/01")
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
                    CreatedAt = DateTime.Parse("2025/01/01")
                });
        });
        modelBuilder.Entity<CompetitionEntity>(entity =>
        {
            entity.ToTable("Competition");
        });
    }
}