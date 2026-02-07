using Athlitix.Data;
using Athlitix.Entities;
using Athlitix.Models;
using Athlitix.Services.Interfaces;
using Athlitix.Utilities.Mappers;
using Microsoft.EntityFrameworkCore;

namespace Athlitix.Services;

public class ParticipantService : IParticipantService
{
    private readonly AthlitixContext _dbContext;
    private readonly ILogger<ParticipantService> _logger;
    private readonly IMapper<ParticipantEntity, ParticipantModel> _mapper;

    public ParticipantService(AthlitixContext dbContext, ILogger<ParticipantService> logger, IMapper<ParticipantEntity, ParticipantModel> mapper)
    {
        _dbContext = dbContext;
        _logger = logger;
        _mapper = mapper;
    }

    public IEnumerable<ParticipantModel> Get(Guid organizationId)
    {
        var list = new List<ParticipantModel>();

        _logger.LogInformation("Getting participants for organization id:{organizationId}.", organizationId);

        var participants = _dbContext.Participants.Include(e => e.Team).Where(e => e.Team.OrganizationId == organizationId);
        foreach (var participant in participants) {
            list.Add(_mapper.ToModel(participant));
        }

        return list;
    }
}
