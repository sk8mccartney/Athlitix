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

        var competition = _dbContext.Competitions.Single(e => e.Id == id);

        return _mapper.ToModel(competition);
    }

    public IEnumerable<CompetitionModel> Get(Guid organizationId)
    {
        var list = new List<CompetitionModel>();

        _logger.LogInformation("Getting competitions for organization id:{organizationId}.", organizationId);

        var competitions = _dbContext.Competitions.Where(e => e.OrganizationId == organizationId).OrderBy(e => e.StartDate);
        foreach (var competition in competitions)
        {
            var competitionModel = _mapper.ToModel(competition);
            competitionModel.EventCount = competition.Events.Count();

            list.Add(competitionModel);
        }

        return list;
    }

    public void Save(CompetitionRequest request)
    {
        _logger.LogInformation("Saving competition: {name}.", request.Name);

        CompetitionEntity competition;

        if (!request.Id.Equals(Guid.Empty))
        {
            competition = _dbContext.Competitions.First(x => x.Id.Equals(request.Id));
            competition.Name = request.Name;
            competition.Description = request.Description;
            competition.StartDate = DateTime.Parse(request.StartDate + " " + request.StartTime);

            _dbContext.Competitions.Update(competition);
            _dbContext.SaveChanges();
        }
        else
        {
            competition = new CompetitionEntity
            {
                Id = Guid.NewGuid(),
                CreatedBy = "skate.mccartney@hotmail.com",
                Name = request.Name,
                Description = request.Description,
                StartDate = DateTime.Parse(request.StartDate + " " + request.StartTime),
                OrganizationId = request.OrganizationId
            };

            _dbContext.Competitions.Add(competition);
            _dbContext.SaveChanges();
        }
    }
}