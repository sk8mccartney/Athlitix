using Athlitix.Models;
using Athlitix.Services.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Athlitix.Pages;

public class IndexModel(ILogger<IndexModel> logger, IOrganizationService organizationService, IEventTypeService eventTypeService, ITeamService teamService, IEventService eventService, ICompetitionService competitionService, IParticipantService participantService) : PageModel
{
    private readonly ILogger<IndexModel> _logger = logger;
    private readonly IOrganizationService _organizationService = organizationService;
    private readonly IEventTypeService _eventTypeService = eventTypeService;
    private readonly ITeamService _teamService = teamService;
    private readonly IEventService _eventService = eventService;
    private readonly ICompetitionService _competitionService = competitionService;
    private readonly IParticipantService _participantService = participantService;
    private readonly Guid _organizationId = Guid.Parse("5835ca66-1356-42a5-a36a-cf1a019189f1");

    public string OrganizationName { get; set; } = default!;
    public string OrganizationDescription { get; set; } = default!;
    public required IEnumerable<EventTypeModel> EventTypes { get; set; }
    public required IEnumerable<TeamModel> Teams { get; set; }
    public required IEnumerable<EventModel> Events { get; set; }
    public required IEnumerable<CompetitionModel> Competitions { get; set; }
    public required IEnumerable<ParticipantModel> Participants { get; set; }

    public void OnGet()
    {
        var organization = _organizationService.GetSingle(_organizationId);

        OrganizationName = organization.Name;
        OrganizationDescription = organization.Description;

        EventTypes = _eventTypeService.Get(_organizationId);
        Teams = _teamService.Get(_organizationId);
        Events = _eventService.Get(_organizationId);
        Competitions = _competitionService.Get(_organizationId);
        Participants = _participantService.Get(_organizationId);
    }
}