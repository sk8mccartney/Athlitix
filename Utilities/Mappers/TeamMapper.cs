using Athlitix.Entities;
using Athlitix.Models;

namespace Athlitix.Utilities.Mappers;

public class TeamMapper : BaseMapper<TeamEntity, TeamModel>
{
    protected override void MapEntityToModel(TeamEntity entity, TeamModel model)
    {
        model.Name = entity.Name;
        model.Description = entity.Description;
    }

    protected override void MapModelToEntity(TeamModel model, TeamEntity entity)
    {
        entity.Name = model.Name;
        entity.Description = model.Description;
    }
}