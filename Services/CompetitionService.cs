using Athlitix.Data;
using Athlitix.Entities;
using Athlitix.Models;
using Athlitix.Services.Interfaces;
using Athlitix.Utilities.Mappers;

namespace Athlitix.Services;

public class CompetitionService : ICompetitionService
{
    private readonly AthlitixContext _dbContext;
    private readonly ILogger<CompetitionService> _logger;
    private readonly IMapper<CompetitionEntity, CompetitionModel> _mapper;

    public CompetitionService(AthlitixContext dbContext, ILogger<CompetitionService> logger, IMapper<CompetitionEntity, CompetitionModel> mapper)
    {
        _dbContext = dbContext;
        _logger = logger;
        _mapper = mapper;
    }

    public IEnumerable<CompetitionModel> Get(Guid organizationId)
    {
        var list = new List<CompetitionModel>();

        _logger.LogInformation("Getting competitions for organization id:{organizationId}.", organizationId);

        var competitions = _dbContext.Competitions.Where(e => e.OrganizationId == organizationId).OrderBy(e => e.StartDate);
        foreach (var competition in competitions) {
            list.Add(_mapper.ToModel(competition));
        }

        return list;
    }
}
