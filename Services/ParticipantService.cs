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

        // Get single participant entity
        var participant = _dbContext.Participants.Single(e => e.Id == id);

        // Convert to model and return
        return _participantMapper.ToModel(participant);
    }

    public IEnumerable<ParticipantModel> Get(Guid organizationId)
    {
        var list = new List<ParticipantModel>();

        _logger.LogInformation("Getting participants for organization id:{organizationId}.", organizationId);

        // Get list of active participants from database that are active
        var participants = _dbContext.Participants.Include(e => e.Team).Where(e => e.Team.OrganizationId == organizationId && e.IsActive);
        foreach (var participant in participants) {
            // Convert to participant model
            var participantModel = _participantMapper.ToModel(participant);
            participantModel.Team = _teamMapper.ToModel(participant.Team);

            list.Add(participantModel);
        }

        // Return list of participants
        return list;
    }

    public void Save(ParticipantRequest request)
    {
        _logger.LogInformation("Saving participant: {firstName}.", request.FirstName);

        ParticipantEntity participant;

        // When participant already exists
        if (!request.Id.Equals(Guid.Empty))
        {
            // Retrieve from database and update properties
            participant = _dbContext.Participants.First(x => x.Id.Equals(request.Id));
            participant.FirstName = request.FirstName;
            participant.LastName = request.LastName;
            participant.NickName = request.NickName;
            participant.Email = request.Email;
            participant.PhoneNumber = request.PhoneNumber;
            participant.DateOfBirth = DateTime.Parse(request.DateOfBirth);
            participant.Gender = request.Gender;
            participant.HasMedicalClearance = request.HasMedicalClearance;
            participant.WeightKg = request.WeightKg;
            participant.HeightCm = request.HeightCm;
            participant.Record = request.Record;
            participant.Notes = request.Notes;
            participant.TeamId = request.TeamId;

            // Update participant and save to database
            _dbContext.Participants.Update(participant);
            _dbContext.SaveChanges();
        }
        else
        {
            // When participant is new, create it
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
                Gender = request.Gender,
                HasMedicalClearance = request.HasMedicalClearance,
                WeightKg = request.WeightKg,
                HeightCm = request.HeightCm,
                Record = request.Record,
                Notes = request.Notes,
                TeamId = request.TeamId
            };

            // Add and save to database
            _dbContext.Participants.Add(participant);
            _dbContext.SaveChanges();
        }
    }

    public void Delete(Guid id)
    {
        _logger.LogInformation("Delete participant Id: {id}.", id);

        // Retrieve participant from database
        var participant = _dbContext.Participants.FirstOrDefault(c => c.Id == id);
        if (participant == null)
        {
            throw new Exception($"Can not find competion with id {id}");
        }

        // Enable soft delete flag
        participant.IsActive = false;

        // Update and save to database
        _dbContext.Participants.Update(participant);
        _dbContext.SaveChanges();
    }
}
