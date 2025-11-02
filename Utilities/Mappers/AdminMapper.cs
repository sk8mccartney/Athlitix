using Athlitix.Entities;
using Athlitix.Models;

namespace Athlitix.Utilities.Mappers;

public class AdminMapper : BaseMapper<AdminEntity, AdminModel>
{
    protected override void MapEntityToModel(AdminEntity entity, AdminModel model)
    {
        model.OrganizationId = entity.OrganizationId;
        model.FirstName = entity.FirstName;
        model.LastName = entity.LastName;
        model.PhoneNumber = entity.PhoneNumber;
        model.Email = entity.Email;
    }

    protected override void MapModelToEntity(AdminModel model, AdminEntity entity)
    {
        entity.OrganizationId = model.OrganizationId;
        entity.FirstName = model.FirstName;
        entity.LastName = model.LastName;
        entity.PhoneNumber = model.PhoneNumber;
        entity.Email = model.Email;
    }
}