using Athlitix.Data;
using Athlitix.Entities;
using Athlitix.Models;
using Athlitix.Services.Interfaces;
using Athlitix.Utilities.Mappers;

namespace Athlitix.Services;

public class EventTypeService : IEventTypeService
{
    private readonly AthlitixContext _dbContext;
    private readonly ILogger<EventTypeService> _logger;
    private readonly IMapper<EventTypeEntity, EventTypeModel> _mapper;

    public EventTypeService(AthlitixContext dbContext, ILogger<EventTypeService> logger, IMapper<EventTypeEntity, EventTypeModel> mapper)
    {
        _dbContext = dbContext;
        _logger = logger;
        _mapper = mapper;
    }

    public IEnumerable<EventTypeModel> Get(Guid organizationId)
    {
        var list = new List<EventTypeModel>();

        _logger.LogInformation("Getting events for organization id:{organizationId}.", organizationId);

        var eventTypes = _dbContext.EventTypes.Where(e => e.OrganizationId == organizationId);
        foreach (var eventType in eventTypes) {
            list.Add(_mapper.ToModel(eventType));
        }

        return list;
    }
}
