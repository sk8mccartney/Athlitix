using Athlitix.Data;
using Athlitix.Entities;
using Athlitix.Models;
using Athlitix.Services.Interfaces;
using Athlitix.Utilities.Mappers;
using Microsoft.EntityFrameworkCore;

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

        var teams = _dbContext.Teams.Include(x => x.Participants).Where(e => e.OrganizationId == organizationId);
        foreach (var team in teams) {
            var teamModel = _mapper.ToModel(team);
            teamModel.ParticipantCount = team.Participants.Where(x => x.IsActive).Count();

            list.Add(teamModel);
        }

        return list;
    }
}
