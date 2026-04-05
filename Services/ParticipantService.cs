using Athlitix.Controllers.Requests;
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
    private readonly IMapper<ParticipantEntity, ParticipantModel> _participantMapper;
    private readonly IMapper<TeamEntity, TeamModel> _teamMapper;

    public ParticipantService(AthlitixContext dbContext, ILogger<ParticipantService> logger, IMapper<ParticipantEntity, ParticipantModel> participantMapper, IMapper<TeamEntity, TeamModel> teamMapper)
    {
        _dbContext = dbContext;
        _logger = logger;
        _participantMapper = participantMapper;
        _teamMapper = teamMapper;
    }

    public ParticipantModel GetSingle(Guid id)
    {
        _logger.LogInformation("Getting participant with {id}.", id);

        var participant = _dbContext.Participants.Single(e => e.Id == id);

        return _participantMapper.ToModel(participant);
    }

    public IEnumerable<ParticipantModel> Get(Guid organizationId)
    {
        var list = new List<ParticipantModel>();

        _logger.LogInformation("Getting participants for organization id:{organizationId}.", organizationId);

        var participants = _dbContext.Participants.Include(e => e.Team).Where(e => e.Team.OrganizationId == organizationId);
        foreach (var participant in participants) {
            var participantModel = _participantMapper.ToModel(participant);
            participantModel.Team = _teamMapper.ToModel(participant.Team);

            list.Add(participantModel);
        }

        return list;
    }

    public void Save(ParticipantRequest request)
    {
        _logger.LogInformation("Saving participant: {firstName}.", request.FirstName);

        ParticipantEntity participant;

        if (!request.Id.Equals(Guid.Empty))
        {
            participant = _dbContext.Participants.First(x => x.Id.Equals(request.Id));
            participant.FirstName = request.FirstName;
            participant.LastName = request.LastName;
            participant.NickName = request.NickName;
            participant.Email = request.Email;
            participant.PhoneNumber = request.PhoneNumber;
            participant.DateOfBirth = DateTime.Parse(request.DateOfBirth);
            participant.WeightKg = request.WeightKg;
            participant.HeightCm = request.HeightCm;
            participant.Record = request.Record;
            participant.Notes = request.Notes;
            participant.TeamId = request.TeamId;

            _dbContext.Participants.Update(participant);
            _dbContext.SaveChanges();
        }
        else
        {
            participant = new ParticipantEntity
            {
                Id = Guid.NewGuid(),
                CreatedBy = "skate.mccartney@hotmail.com",
                FirstName = request.FirstName,
                LastName = request.LastName,
                NickName = request.NickName,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                DateOfBirth = DateTime.Parse(request.DateOfBirth),
                WeightKg = request.WeightKg,
                HeightCm = request.HeightCm,
                Record = request.Record,
                Notes = request.Notes,
                TeamId = request.TeamId
            };

            _dbContext.Participants.Add(participant);
            _dbContext.SaveChanges();
        }
    }

    public void Delete(Guid id)
    {
        _logger.LogInformation("Delete participant Id: {id}.", id);

        var participant = _dbContext.Participants.FirstOrDefault(c => c.Id == id);
        if (participant == null)
        {
            throw new Exception($"Can not find competion with id {id}");
        }

        _dbContext.Participants.Remove(participant);
        _dbContext.SaveChanges();
    }
}
