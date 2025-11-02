using Athlitix.Models;

namespace Athlitix.Services.Interfaces;

public interface IEventTypeService
{
    IEnumerable<EventTypeModel> Get(Guid organizationId);
}
