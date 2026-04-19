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
        _logger.LogInformation("Getting event with id:{id}.", id);

        // Get single event entity from database
        var evt = _dbContext.Events.Single(e => e.Id == id);

        // Convert to event model and return
        return _mapper.ToModel(evt);
    }

    public IEnumerable<EventModel> Get(Guid organizationId)
    {
        var list = new List<EventModel>();

        _logger.LogInformation("Getting events for organization id:{organizationId}.", organizationId);

        // Get list of event entities
        var events = _dbContext.Events.Include(e => e.Competition).Where(e => e.Competition.OrganizationId == organizationId && e.IsActive).OrderBy(e => e.StartDate);
        foreach (var evt in events)
        {
            // Convert to event models
            var eventModel = _mapper.ToModel(evt);
            eventModel.Competition = _competitionMapper.ToModel(evt.Competition);

            list.Add(eventModel);
        }

        // Return the list of event models
        return list;
    }

    public void Save(EventRequest request)
    {
        _logger.LogInformation("Saving event: {name}.", request.Name);

        EventEntity evt;

        // When the event exists
        if (!request.Id.Equals(Guid.Empty))
        {
            // Retreive from database and update properties
            evt = _dbContext.Events.First(x => x.Id.Equals(request.Id));
            evt.Name = request.Name;
            evt.Description = request.Description;
            evt.WeightRange = request.WeightRange;
            evt.StartDate = DateTime.Parse(request.StartDate + " " + request.StartTime);
            evt.CompetitionId= request.CompetitionId;
            evt.EventTypeId = request.EventTypeId;

            // Update entity and save to database
            _dbContext.Events.Update(evt);
            _dbContext.SaveChanges();
        }
        else
        {
            // When event is new create entity
            evt = new EventEntity
            {
                Id = Guid.NewGuid(),
                CreatedBy = "skate.mccartney@hotmail.com",
                Name = request.Name,
                Description = request.Description,
                WeightRange = request.WeightRange,
                StartDate = DateTime.Parse(request.StartDate + " " + request.StartTime),
                CompetitionId = request.CompetitionId,
                EventTypeId = request.EventTypeId
            };

            // Add and save to database
            _dbContext.Events.Add(evt);
            _dbContext.SaveChanges();
        }
    }

    public void Delete(Guid id)
    {
        _logger.LogInformation("Delete event Id: {id}.", id);

        // Get the event from the database
        var evt = _dbContext.Events.FirstOrDefault(c => c.Id == id);
        if (evt == null)
        {
            throw new Exception($"Can not find competion with id {id}");
        }

        // Set soft delete flag
        evt.IsActive = false;

        // Update and save to database
        _dbContext.Events.Update(evt);
        _dbContext.SaveChanges();
    }
}
