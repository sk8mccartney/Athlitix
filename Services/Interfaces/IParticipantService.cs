using Athlitix.Controllers.Requests;
using Athlitix.Entities;
using Athlitix.Models;
using Athlitix.Utilities.Mappers;
using Microsoft.EntityFrameworkCore;

namespace Athlitix.Services.Interfaces;

public interface IParticipantService
{
    ParticipantModel GetSingle(Guid id);
    IEnumerable<ParticipantModel> Get(Guid organizationId);
    void Save(ParticipantRequest request);
    void Delete(Guid id);
}
