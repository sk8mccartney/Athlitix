using Athlitix.Models;
using Athlitix.Services.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Athlitix.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IOrganizationService _organizationService;
    private readonly IEventTypeService _eventTypeService;
    private readonly Guid _organizationId = Guid.Parse("5835ca66-1356-42a5-a36a-cf1a019189f1");

    public string OrganizationName { get; set; } = default!;
    public string OrganizationDescription { get; set; } = default!;
    public IEnumerable<EventTypeModel> EventTypes { get; set; } 

    public IndexModel(ILogger<IndexModel> logger, IOrganizationService organizationService, IEventTypeService eventTypeService)
    {
        _logger = logger;
        _organizationService = organizationService;
        _eventTypeService = eventTypeService;
    }

    public void OnGet()
    {
        var organization = _organizationService.GetSingle(_organizationId);

        OrganizationName = organization.Name;
        OrganizationDescription = organization.Description;

        EventTypes = _eventTypeService.Get(_organizationId);
    }
}