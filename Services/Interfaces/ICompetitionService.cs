using Athlitix.Models;

namespace Athlitix.Services.Interfaces;

public interface ICompetitionService
{
    IEnumerable<CompetitionModel> Get(Guid organizationId);
}
