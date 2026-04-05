using Athlitix.Models;
using Athlitix.Services.Interfaces;

namespace Athlitix.Pages;

public class IndexModel(ILogger<IndexModel> logger, IOrganizationService organizationService, IEventTypeService eventTypeService, ITeamService teamService, IEventService eventService, ICompetitionService competitionService, IParticipantService participantService) : LayoutModel(organizationService)
{
    private readonly ILogger<IndexModel> _logger = logger;
    private readonly IEventTypeService _eventTypeService = eventTypeService;
    private readonly ITeamService _teamService = teamService;
    private readonly IEventService _eventService = eventService;
    private readonly ICompetitionService _competitionService = competitionService;
    private readonly IParticipantService _participantService = participantService;

    public IEnumerable<EventTypeModel> EventTypes { get; set; }
    public IEnumerable<TeamModel> Teams { get; set; }
    public IEnumerable<EventModel> Events { get; set; }
    public IEnumerable<CompetitionModel> Competitions { get; set; }
    public IEnumerable<ParticipantModel> Participants { get; set; }

    public void OnGet()
    {
        _logger.LogInformation("Loading dashboard");

        PageTitle = $"{OrganizationName} Dashboard";
        BreadCrumbName = "dashboard";

        EventTypes = _eventTypeService.Get(OrganizationId);
        Teams = _teamService.Get(OrganizationId);
        Events = _eventService.Get(OrganizationId);
        Competitions = _competitionService.Get(OrganizationId);
        Participants = _participantService.Get(OrganizationId);
    }
}