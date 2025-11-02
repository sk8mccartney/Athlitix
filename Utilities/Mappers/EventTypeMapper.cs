using Athlitix.Entities;
using Athlitix.Models;

namespace Athlitix.Utilities.Mappers;

public class EventTypeMapper : BaseMapper<EventTypeEntity, EventTypeModel>
{
    protected override void MapEntityToModel(EventTypeEntity entity, EventTypeModel model)
    {
        model.Name = entity.Name;
        model.Description = entity.Description;
    }

    protected override void MapModelToEntity(EventTypeModel model, EventTypeEntity entity)
    {
        entity.Name = model.Name;
        entity.Description = model.Description;
    }
}