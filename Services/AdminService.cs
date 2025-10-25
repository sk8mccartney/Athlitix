using Athlitix.Data;
using Athlitix.Models;
using Athlitix.Services.Interfaces;
using Athlitix.Utility.Extensions;

namespace Athlitix.Services;

public class AdminService : IAdminService
{
    private readonly AthlitixContext _dbContext;
    private readonly ILogger<AdminService> _logger;

    public AdminService(AthlitixContext dbContext, ILogger<AdminService> logger)
    {
        _dbContext = dbContext;
        _logger = logger;
    }

    public AdminModel Add(AdminModel adminModel)
    {
        if (string.IsNullOrEmpty(adminModel.FirstName)) throw new ArgumentNullException(nameof(adminModel.FirstName));
        if (string.IsNullOrEmpty(adminModel.LastName)) throw new ArgumentNullException(nameof(adminModel.LastName));
        if (string.IsNullOrEmpty(adminModel.Email)) throw new ArgumentNullException(nameof(adminModel.Email));
        if (string.IsNullOrEmpty(adminModel.PhoneNumber)) throw new ArgumentNullException(nameof(adminModel.PhoneNumber));

        _logger.LogInformation("Create admin {admin}", $"{adminModel.FirstName} {adminModel.LastName}");

        var admin = _dbContext.Admins.Add(adminModel.ToEntity());
        _dbContext.SaveChanges();

        return admin.Entity.ToModel();
    }

    public AdminModel GetSingle(Guid id)
    {
        var admin = _dbContext.Admins.Single(x => x.Id == id);

        return admin.ToModel();
    }
}
