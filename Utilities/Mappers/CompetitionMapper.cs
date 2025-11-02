using Athlitix.Entities;
using Athlitix.Models;

namespace Athlitix.Utilities.Mappers;

public class CompetitionMapper : BaseMapper<CompetitionEntity, CompetitionModel>
{
    protected override void MapEntityToModel(CompetitionEntity entity, CompetitionModel model)
    {
        model.Name = entity.Name;
        model.Description = entity.Description;
        model.StartDate = entity.StartDate;
        model.FinishDate = entity.FinishDate;
    }

    protected override void MapModelToEntity(CompetitionModel model, CompetitionEntity entity)
    {
        entity.Name = model.Name;
        entity.Description = model.Description;
        entity.StartDate = model.StartDate;
        entity.FinishDate = model.FinishDate;
    }
}