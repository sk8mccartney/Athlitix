using Athlitix.Entities;
using Athlitix.Models;

namespace Athlitix.Utilities.Mappers;

public class OrganizationMapper : BaseMapper<OrganizationEntity, OrganizationModel>
{
    protected override void MapEntityToModel(OrganizationEntity entity, OrganizationModel model)
    {
        model.Name = entity.Name;
        model.Description = entity.Description;
    }

    protected override void MapModelToEntity(OrganizationModel model, OrganizationEntity entity)
    {
        entity.Name = model.Name;
        entity.Description = model.Description;
    }
}