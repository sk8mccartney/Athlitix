using Athlitix.Models;

namespace Athlitix.Services.Interfaces;

public interface IEventService
{
    IEnumerable<EventModel> Get(Guid organizationId);
}
