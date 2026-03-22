using Athlitix.Models;
using Athlitix.Services.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Athlitix.Pages;

public class CompetitionPageModel(ILogger<CompetitionPageModel> logger, IOrganizationService organizationService, ICompetitionService competitionService) : PageModel
{
    private readonly ILogger<CompetitionPageModel> _logger = logger;
    private readonly IOrganizationService _organizationService = organizationService;
    private readonly ICompetitionService _competitionService = competitionService;

    private readonly Guid _organizationId = Guid.Parse("5835ca66-1356-42a5-a36a-cf1a019189f1");
    public string OrganizationName { get; set; } = default!;
    public string OrganizationDescription { get; set; } = default!;

    public required IEnumerable<CompetitionModel> Competitions { get; set; }

    public void OnGet()
    {
        _logger.LogInformation("Loading competition page");
        var organization = _organizationService.GetSingle(_organizationId);

        OrganizationName = organization.Name;
        OrganizationDescription = organization.Description;

        Competitions = _competitionService.Get(_organizationId);
    }
}