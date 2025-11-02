using Athlitix.Data;
using Athlitix.Entities;
using Athlitix.Models;
using Athlitix.Services.Interfaces;
using Athlitix.Utilities.Mappers;

namespace Athlitix.Services;

public class OrganizationService : IOrganizationService
{
    private readonly AthlitixContext _dbContext;
    private readonly ILogger<OrganizationService> _logger;
    private readonly IMapper<OrganizationEntity, OrganizationModel> _mapper;

    public OrganizationService(AthlitixContext dbContext, ILogger<OrganizationService> logger, IMapper<OrganizationEntity, OrganizationModel> mapper)
    {
        _dbContext = dbContext;
        _logger = logger;
        _mapper = mapper;
    }

    public OrganizationModel GetSingle(Guid id)
    {
        _logger.LogInformation("Retrieving organization {organizationId}.", id);
        var organization = _dbContext.Organizations.Single(x => x.Id == id);

        _logger.LogInformation("Retrived organization {name}.", organization.Name);
        return _mapper.ToModel(organization);
    }
}