using Athlitix.Models;
using Athlitix.Services.Interfaces;

namespace Athlitix.Pages;

public class TeamPageModel(ILogger<TeamPageModel> logger, IOrganizationService organizationService, ITeamService teamService) : LayoutModel(organizationService)
{
    private readonly ILogger<TeamPageModel> _logger = logger;
    private readonly ITeamService _teamService = teamService;

    public required IEnumerable<TeamModel> Teams { get; set; }

    public void OnGet()
    {
        _logger.LogInformation("Loading team page");

        PageTitle = $"{OrganizationName} Teams";
        BreadCrumbName = "team";

        Teams = _teamService.Get(OrganizationId);
    }
}