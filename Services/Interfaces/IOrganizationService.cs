using Athlitix.Models;

namespace Athlitix.Services.Interfaces;

public interface IOrganizationService
{
    OrganizationModel GetSingle(Guid id);
}