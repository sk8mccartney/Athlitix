using Athlitix.Controllers.Requests;
using Athlitix.Models;

namespace Athlitix.Services.Interfaces;

public interface IEventService
{
    EventModel GetSingle(Guid id);
    IEnumerable<EventModel> Get(Guid organizationId);
    void Save(EventRequest eventRequest);
    void Delete(Guid id);
}
