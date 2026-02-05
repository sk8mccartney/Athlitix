using Athlitix.Data;
using Athlitix.Entities;
using Athlitix.Models;
using Athlitix.Services.Interfaces;
using Athlitix.Utilities.Mappers;

namespace Athlitix.Services;

public class TeamService : ITeamService
{
    private readonly AthlitixContext _dbContext;
    private readonly ILogger<TeamService> _logger;
    private readonly IMapper<TeamEntity, TeamModel> _mapper;

    public TeamService(AthlitixContext dbContext, ILogger<TeamService> logger, IMapper<TeamEntity, TeamModel> mapper)
    {
        _dbContext = dbContext;
        _logger = logger;
        _mapper = mapper;
    }

    public IEnumerable<TeamModel> Get(Guid organizationId)
    {
        var list = new List<TeamModel>();

        _logger.LogInformation("Getting teams for organization id:{organizationId}.", organizationId);

        var teams = _dbContext.Teams.Where(e => e.OrganizationId == organizationId);
        foreach (var team in teams) {
            list.Add(_mapper.ToModel(team));
        }

        return list;
    }
}
