using Athlitix.Controllers.Requests;
using Athlitix.Models;

namespace Athlitix.Services.Interfaces;

public interface ITeamService
{
    TeamModel GetSingle(Guid id);
    IEnumerable<TeamModel> Get(Guid organizationId);
    void Save(TeamRequest teamRequest);
    void Delete(Guid id);
}
