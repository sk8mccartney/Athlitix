using Athlitix.Models;

namespace Athlitix.Utility.Extensions;

public static class AdminExtension
{
    public static AdminModel ToModel(this AdminEntity entity)
    {
        if (entity == null) return null!;

        var model = new AdminModel
        {
            OrganizationId = entity.OrganizationId,
            FirstName = entity.FirstName,
            LastName = entity.LastName,
            PhoneNumber = entity.PhoneNumber,
            Email = entity.Email,
            IsActive = entity.IsActive
        };

        CommonExtension.CopyCommonProperties(model, entity);

        return model;
    }

    public static AdminEntity ToEntity(this AdminModel model)
    {
        if (model == null) return null!;

        var entity = new AdminEntity
        {
            OrganizationId = model.OrganizationId,
            FirstName = model.FirstName,
            LastName = model.LastName,
            PhoneNumber = model.PhoneNumber,
            Email = model.Email,
            IsActive = model.IsActive
        };

        CommonExtension.CopyCommonProperties(entity, model);

        return entity;
    }
}