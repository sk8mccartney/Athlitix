using Athlitix.Controllers.Requests;
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
    public TeamModel GetSingle(Guid id)
    {
        var list = new List<TeamModel>();

        _logger.LogInformation("Getting team with id:{id}.", id);

        // Use single to get the team
        var team = _dbContext.Teams.Single(e => e.Id == id);

        // Return single team model
        return _mapper.ToModel(team);
    }

    public IEnumerable<TeamModel> Get(Guid organizationId)
    {
        var list = new List<TeamModel>();

        _logger.LogInformation("Getting teams for organization id:{organizationId}.", organizationId);

        // Get all teams from database for organization that are active
        var teams = _dbContext.Teams.Include(x => x.Participants).Where(e => e.OrganizationId == organizationId && e.IsActive);
        foreach (var team in teams) {
            // Convert team entity to a model
            var teamModel = _mapper.ToModel(team);
            teamModel.ParticipantCount = team.Participants.Where(x => x.IsActive).Count();

            list.Add(teamModel);
        }

        // Return list of team models
        return list;
    }

    public void Save(TeamRequest request)
    {
        _logger.LogInformation("Saving team: {name}.", request.Name);

        TeamEntity team;

        // When entity already exists get entity
        if (!request.Id.Equals(Guid.Empty))
        {
            team = _dbContext.Teams.First(x => x.Id.Equals(request.Id));
            team.Name = request.Name;
            team.Description = request.Description;

            // Update & save changes on database
            _dbContext.Teams.Update(team);
            _dbContext.SaveChanges();
        }
        else
        {
            // When entity does not exist, create a new one
            team = new TeamEntity
            {
                Id = Guid.NewGuid(),
                CreatedBy = "skate.mccartney@hotmail.com",
                Name = request.Name,
                Description = request.Description,
                OrganizationId = request.OrganizationId
            };

            // Add & save changes on database
            _dbContext.Teams.Add(team);
            _dbContext.SaveChanges();
        }
    }

    public void Delete(Guid id)
    {
        // Soft delete of a team
        _logger.LogInformation("Delete team Id: {id}.", id);

        var team = _dbContext.Teams.FirstOrDefault(c => c.Id == id);
        if (team == null)
        {
            throw new Exception($"Can not find competion with id {id}");
        }

        // Set active flag
        team.IsActive = false;

        // Update & save changes on database
        _dbContext.Teams.Update(team);
        _dbContext.SaveChanges();
    }
}
