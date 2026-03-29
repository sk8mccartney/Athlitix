using Athlitix.Controllers.Requests;
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
    private readonly IMapper<EventEntity, EventModel> _mapper;
    private readonly IMapper<CompetitionEntity, CompetitionModel> _competitionMapper;

    public EventService(AthlitixContext dbContext, ILogger<EventService> logger, IMapper<EventEntity, EventModel> mapper, IMapper<CompetitionEntity, CompetitionModel> competitionMapper)
    {
        _dbContext = dbContext;
        _logger = logger;
        _mapper = mapper;
        _competitionMapper = competitionMapper;
    }

    public EventModel GetSingle(Guid id)
    {
        var list = new List<EventModel>();

        _logger.LogInformation("Getting event with id:{id}.", id);

        var evt = _dbContext.Events.Single(e => e.Id == id);

        return _mapper.ToModel(evt);
    }

    public IEnumerable<EventModel> Get(Guid organizationId)
    {
        var list = new List<EventModel>();

        _logger.LogInformation("Getting events for organization id:{organizationId}.", organizationId);

        var events = _dbContext.Events.Include(e => e.Competition).Where(e => e.Competition.OrganizationId == organizationId).OrderBy(e => e.StartDate);
        foreach (var evt in events)
        {
            var eventModel = _mapper.ToModel(evt);
            eventModel.Competition = _competitionMapper.ToModel(evt.Competition);

            list.Add(eventModel);
        }

        return list;
    }

    public void Save(EventRequest request)
    {
        _logger.LogInformation("Saving event: {name}.", request.Name);

        EventEntity evt;

        if (!request.Id.Equals(Guid.Empty))
        {
            evt = _dbContext.Events.First(x => x.Id.Equals(request.Id));
            evt.Name = request.Name;
            evt.Description = request.Description;
            evt.StartDate = DateTime.Parse(request.StartDate + " " + request.StartTime);
            evt.CompetitionId= request.CompetitionId;
            evt.EventTypeId = request.EventTypeId;

            _dbContext.Events.Update(evt);
            _dbContext.SaveChanges();
        }
        else
        {
            evt = new EventEntity
            {
                Id = Guid.NewGuid(),
                CreatedBy = "skate.mccartney@hotmail.com",
                Name = request.Name,
                Description = request.Description,
                StartDate = DateTime.Parse(request.StartDate + " " + request.StartTime),
                CompetitionId = request.CompetitionId,
                EventTypeId = request.EventTypeId
            };

            _dbContext.Events.Add(evt);
            _dbContext.SaveChanges();
        }
    }

    public void Delete(Guid id)
    {
        _logger.LogInformation("Delete event Id: {id}.", id);

        var evt = _dbContext.Events.FirstOrDefault(c => c.Id == id);
        if (evt == null)
        {
            throw new Exception($"Can not find competion with id {id}");
        }

        _dbContext.Events.Remove(evt);
        _dbContext.SaveChanges();
    }
}
