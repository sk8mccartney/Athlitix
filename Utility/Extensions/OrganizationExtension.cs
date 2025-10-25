using Athlitix.Models;

namespace Athlitix.Utility.Extensions;

public static class OrganizationExtension
{
    public static OrganizationModel ToModel(this OrganizationEntity entity)
    {
        if (entity == null) return null!;

        var model = new OrganizationModel
        {
            Name = entity.Name,
            Description = entity.Description,
            IsActive = entity.IsActive
        };

        CommonExtension.CopyCommonProperties(model, entity);

        return model;
    }

    public static OrganizationEntity ToEntity(this OrganizationModel model)
    {
        if (model == null) return null!;

        var entity = new OrganizationEntity
        {
            Name = model.Name,
            Description = model.Description,
            IsActive = model.IsActive
        };

        CommonExtension.CopyCommonProperties(entity, model);

        return entity;
    }
}