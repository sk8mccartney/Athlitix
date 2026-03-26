using Athlitix.Services.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Athlitix.Models;

public class LayoutModel : PageModel
{

    private readonly IOrganizationService _organizationService;

    public readonly Guid OrganizationId = Guid.Parse("5835ca66-1356-42a5-a36a-cf1a019189f1");

    public string OrganizationName { get; set; } = default!;
    public string OrganizationDescription { get; set; } = default!;
    public string PageTitle { get; set; } = default!;
    public string BreadCrumbName { get; set; } = default!;

    public LayoutModel(IOrganizationService organizationService)
    {
        _organizationService = organizationService;

        var organization = _organizationService.GetSingle(OrganizationId);
        OrganizationName = organization.Name;
        OrganizationDescription = organization.Description;
    }
}