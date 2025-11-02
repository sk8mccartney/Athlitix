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
        model.FinishDate = entity.FinishDate;
    }

    protected override void MapModelToEntity(EventModel model, EventEntity entity)
    {
        entity.Name = model.Name;
        entity.Description = model.Description;
        entity.StartDate = model.StartDate;
        entity.FinishDate = model.FinishDate;
    }
}