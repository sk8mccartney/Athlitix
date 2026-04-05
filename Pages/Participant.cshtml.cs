using Athlitix.Models;
using Athlitix.Services.Interfaces;

namespace Athlitix.Pages;

public class ParticipantPageModel(ILogger<ParticipantPageModel> logger, IOrganizationService organizationService, IParticipantService participantService, ITeamService teamService) : LayoutModel(organizationService)
{
    private readonly ILogger<ParticipantPageModel> _logger = logger;
    private readonly IParticipantService _participantService = participantService;
    private readonly ITeamService _teamService = teamService;

    public required IEnumerable<ParticipantModel> Participants { get; set; }
    public required IEnumerable<TeamModel> Teams { get; set; }

    public void OnGet(Guid? teamId)
    {
        _logger.LogInformation("Loading participant page");

        PageTitle = $"{OrganizationName} Participant";
        BreadCrumbName = "participant";

        Participants = _participantService.Get(OrganizationId);
        if(teamId is not null)
        {
            Participants = Participants.Where(x => x.TeamId == teamId);
        }

        Teams = _teamService.Get(OrganizationId);
    }
}