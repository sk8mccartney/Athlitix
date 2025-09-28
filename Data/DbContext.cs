using Athlitix.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Athlitix.Data;

public class AthlitixContext : DbContext
{
    public DbSet<Admin> Admins { get; set; }

    public AthlitixContext(DbContextOptions<AthlitixContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.ToTable("Admin");
        });
    }
}