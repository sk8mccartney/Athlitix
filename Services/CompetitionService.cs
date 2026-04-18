using Athlitix.Controllers.Requests;
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

    public CompetitionModel GetSingle(Guid id)
    {
        var list = new List<CompetitionModel>();

        _logger.LogInformation("Getting competition with id:{id}.", id);

        // Get a single competition entity
        var competition = _dbContext.Competitions.Single(e => e.Id == id);

        // Return competition model
        return _mapper.ToModel(competition);
    }

    public IEnumerable<CompetitionModel> Get(Guid organizationId)
    {
        var list = new List<CompetitionModel>();

        _logger.LogInformation("Getting competitions for organization id:{organizationId}.", organizationId);

        // Get list of competition entites
        var competitions = _dbContext.Competitions.Where(e => e.OrganizationId == organizationId && e.IsActive).OrderBy(e => e.StartDate);
        foreach (var competition in competitions)
        {
            // Convert competitions to models
            var competitionModel = _mapper.ToModel(competition);

            // Count the number of associated events
            competitionModel.EventCount = competition.Events.Count();

            // Add to list
            list.Add(competitionModel);
        }

        // Return list of competition models
        return list;
    }

    public void Save(CompetitionRequest request)
    {
        _logger.LogInformation("Saving competition: {name}.", request.Name);

        CompetitionEntity competition;

        // Get guid from the request
        var teamId = Guid.Empty;
        if (!request.TeamId.Equals(string.Empty)) {
            Guid.TryParse(request.TeamId, out teamId);
        }

        // When guid exists
        if (!request.Id.Equals(Guid.Empty))
        {
            // Get competition entity and change properties
            competition = _dbContext.Competitions.First(x => x.Id.Equals(request.Id));
            competition.Name = request.Name;
            competition.Description = request.Description;
            competition.StartDate = DateTime.Parse(request.StartDate + " " + request.StartTime);
            competition.TeamId = teamId.Equals(Guid.Empty) ? null : teamId;

            // Update and save to database
            _dbContext.Competitions.Update(competition);
            _dbContext.SaveChanges();
        }
        else
        {
            // When a new competition, create entity
            competition = new CompetitionEntity
            {
                Id = Guid.NewGuid(),
                CreatedBy = "skate.mccartney@hotmail.com",
                Name = request.Name,
                Description = request.Description,
                StartDate = DateTime.Parse(request.StartDate + " " + request.StartTime),
                TeamId = teamId.Equals(Guid.Empty) ? null : teamId,
                OrganizationId = request.OrganizationId
            };

            // Add and save to database
            _dbContext.Competitions.Add(competition);
            _dbContext.SaveChanges();
        }
    }

    public void Delete(Guid id)
    {
        _logger.LogInformation("Delete competition Id: {id}.", id);

        // Retreive competition entity from database
        var competition = _dbContext.Competitions.FirstOrDefault(c => c.Id == id);
        if (competition == null)
        {
            throw new Exception($"Can not find competion with id {id}");
        }

        // Set soft delete flag
        competition.IsActive = false;

        // Update and save competition to database
        _dbContext.Competitions.Update(competition);
        _dbContext.SaveChanges();
    }
}