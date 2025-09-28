using Athlitix.Services.Models;

namespace Athlitix.Services.Interfaces;

public interface IAdminService
{
    AdminModel GetSingle(Guid id);
    AdminModel Add(AdminModel admin);
}
