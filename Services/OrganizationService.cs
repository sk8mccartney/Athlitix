using Athlitix.Data;
using Athlitix.Models;
using Athlitix.Services.Interfaces;
using Athlitix.Utility.Extensions;

namespace Athlitix.Services;

public class OrganizationService : IOrganizationService
{
    private readonly AthlitixContext _dbContext;
    private readonly ILogger<OrganizationService> _logger;

    public OrganizationService(AthlitixContext dbContext, ILogger<OrganizationService> logger)
    {
        _dbContext = dbContext;
        _logger = logger;
    }

    public OrganizationModel GetSingle(Guid id)
    {
        _logger.LogInformation("Retrieving organization {organizationId}", id);
        var organization = _dbContext.Organizations.Single(x => x.Id == id);

        _logger.LogInformation("Retrived organization {name}", organization.Name);
        return organization.ToModel();
    }
}