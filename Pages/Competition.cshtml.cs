using Athlitix.Models;
using Athlitix.Services.Interfaces;

namespace Athlitix.Pages;

public class CompetitionPageModel(ILogger<CompetitionPageModel> logger, IOrganizationService organizationService, ICompetitionService competitionService, ITeamService teamService) : LayoutModel(organizationService)
{
    private readonly ILogger<CompetitionPageModel> _logger = logger;
    private readonly ICompetitionService _competitionService = competitionService;
    private readonly ITeamService _teamService = teamService;

    public required IEnumerable<CompetitionModel> Competitions { get; set; }
    public required IEnumerable<TeamModel> Teams { get; set; }

    public void OnGet()
    {
        _logger.LogInformation("Loading competition page");

        PageTitle = $"{OrganizationName} Competitions";
        BreadCrumbName = "competition";

        Competitions = _competitionService.Get(OrganizationId);
        Teams = _teamService.Get(OrganizationId);
    }
}