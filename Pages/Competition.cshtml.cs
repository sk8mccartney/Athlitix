using Athlitix.Models;
using Athlitix.Services.Interfaces;

namespace Athlitix.Pages;

public class CompetitionPageModel(ILogger<CompetitionPageModel> logger, IOrganizationService organizationService, ICompetitionService competitionService) : LayoutModel(organizationService)
{
    private readonly ILogger<CompetitionPageModel> _logger = logger;
    private readonly ICompetitionService _competitionService = competitionService;

    public required IEnumerable<CompetitionModel> Competitions { get; set; }

    public void OnGet()
    {
        _logger.LogInformation("Loading competition page");

        PageTitle = $"{OrganizationName} Competitions";
        BreadCrumbName = "competition";

        Competitions = _competitionService.Get(OrganizationId);
    }
}