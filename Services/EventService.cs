using Athlitix.Data;
using Athlitix.Entities;
using Athlitix.Models;
using Athlitix.Services.Interfaces;
using Athlitix.Utilities.Mappers;
using Microsoft.EntityFrameworkCore;

namespace Athlitix.Services;

public class EventService : IEventService
{
    private readonly AthlitixContext _dbContext;
    private readonly ILogger<EventService> _logger;
    private readonly IMapper<EventEntity, EventModel> _eventMapper;
    private readonly IMapper<CompetitionEntity, CompetitionModel> _competitionMapper;

    public EventService(AthlitixContext dbContext, ILogger<EventService> logger, IMapper<EventEntity, EventModel> eventMapper, IMapper<CompetitionEntity, CompetitionModel> competitionMapper)
    {
        _dbContext = dbContext;
        _logger = logger;
        _eventMapper = eventMapper;
        _competitionMapper = competitionMapper;
    }

    public IEnumerable<EventModel> Get(Guid organizationId)
    {
        var list = new List<EventModel>();

        _logger.LogInformation("Getting events for organization id:{organizationId}.", organizationId);

        var events = _dbContext.Events.Include(e => e.Competition).Where(e => e.Competition.OrganizationId == organizationId).OrderBy(e => e.StartDate);
        foreach (var evt in events) {
            var eventModel = _eventMapper.ToModel(evt);
            eventModel.Competition = _competitionMapper.ToModel(evt.Competition);

            list.Add(eventModel);
        }

        return list;
    }
}
