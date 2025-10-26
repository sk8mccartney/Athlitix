using Athlitix.Services.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Athlitix.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IOrganizationService _organizationService;
    private readonly Guid _organizationId = Guid.Parse("5835ca66-1356-42a5-a36a-cf1a019189f1");

    public string OrganizationName { get; set; } = default!;

    public IndexModel(ILogger<IndexModel> logger, IOrganizationService organizationService)
    {
        _logger = logger;
        _organizationService = organizationService;
    }

    public void OnGet()
    {
        var organization = _organizationService.GetSingle(_organizationId);

        OrganizationName = organization.Name;
    }
}