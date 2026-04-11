using Athlitix.Entities;
using Athlitix.Models;

namespace Athlitix.Utilities.Mappers;

public class EventMapper : BaseMapper<EventEntity, EventModel>
{
    protected override void MapEntityToModel(EventEntity entity, EventModel model)
    {
        model.Name = entity.Name;
        model.Description = entity.Description;
        model.StartDate = entity.StartDate;
        model.CompetitionId = entity.CompetitionId;
        model.EventTypeId = entity.EventTypeId;
    }

    protected override void MapModelToEntity(EventModel model, EventEntity entity)
    {
        entity.Name = model.Name;
        entity.Description = model.Description;
        entity.StartDate = model.StartDate;
        entity.CompetitionId = model.CompetitionId;
        entity.EventTypeId = model.EventTypeId;
    }
}