using Athlitix.Models;
using Athlitix.Services.Interfaces;

namespace Athlitix.Pages;

public class EventsPageModel(ILogger<EventsPageModel> logger, IOrganizationService organizationService, IEventService eventService, IEventTypeService eventTypeService, ICompetitionService competitionService) : LayoutModel(organizationService)
{
    private readonly ILogger<EventsPageModel> _logger = logger;
    private readonly IEventService _eventService = eventService;
    private readonly IEventTypeService _eventTypeService = eventTypeService;
    private readonly ICompetitionService _competitionService = competitionService;

    public required IEnumerable<EventModel> Events { get; set; }
    public required IEnumerable<EventTypeModel> EventTypes { get; set; }
    public required IEnumerable<CompetitionModel> Competitions { get; set; }

    public void OnGet()
    {
        _logger.LogInformation("Loading event page");

        PageTitle = $"{OrganizationName} Events";
        BreadCrumbName = "event";

        Events = _eventService.Get(OrganizationId);
        EventTypes = _eventTypeService.Get(OrganizationId);
        Competitions = _competitionService.Get(OrganizationId);
    }
}