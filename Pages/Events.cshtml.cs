using Athlitix.Models;
using Athlitix.Services.Interfaces;

namespace Athlitix.Pages;

public class EventsPageModel(ILogger<EventsPageModel> logger, IOrganizationService organizationService, IEventService eventService) : LayoutModel(organizationService)
{
    private readonly ILogger<EventsPageModel> _logger = logger;
    private readonly IEventService _eventService = eventService;

    public required IEnumerable<EventModel> Events { get; set; }

    public void OnGet()
    {
        _logger.LogInformation("Loading event page");

        PageTitle = $"{OrganizationName} Events";
        BreadCrumbName = "event";

        Events = _eventService.Get(OrganizationId);
    }
}