using Athlitix.Controllers.Requests;
using Athlitix.Models;

namespace Athlitix.Services.Interfaces;

public interface ICompetitionService
{
    CompetitionModel GetSingle(Guid id);
    IEnumerable<CompetitionModel> Get(Guid organizationId);
    void Save(CompetitionRequest competitionRequest);
    void Delete(Guid id);
}
