using Athlitix.Models;

namespace Athlitix.Services.Interfaces;

public interface ITeamService
{
    IEnumerable<TeamModel> Get(Guid organizationId);
}
