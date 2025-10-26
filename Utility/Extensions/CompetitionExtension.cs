using Athlitix.Models;
using Athlitix.Entities;

namespace Athlitix.Utility.Extensions;

public static class CompetitionExtension
{
    public static CompetitionModel ToModel(this CompetitionEntity entity)
    {
        if (entity == null) return null!;

        var model = new CompetitionModel
        {
            Name = entity.Name,
            Description = entity.Description,
            StartDate = entity.StartDate,
            FinishDate = entity.FinishDate,
            IsActive = entity.IsActive
        };

        CommonExtension.CopyCommonProperties(model, entity);

        return model;
    }

    public static CompetitionEntity ToEntity(this CompetitionModel model)
    {
        if (model == null) return null!;

        var entity = new CompetitionEntity
        {
            Name = model.Name,
            Description = model.Description,
            StartDate = model.StartDate,
            FinishDate = model.FinishDate,
            IsActive = model.IsActive
        };

        CommonExtension.CopyCommonProperties(entity, model);

        return entity;
    }
}