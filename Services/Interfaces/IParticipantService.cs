using Athlitix.Models;

namespace Athlitix.Services.Interfaces;

public interface IParticipantService
{
    IEnumerable<ParticipantModel> Get(Guid organizationId);
}
