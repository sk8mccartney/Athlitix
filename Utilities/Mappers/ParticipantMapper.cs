using Athlitix.Entities;
using Athlitix.Models;
using System.ComponentModel.DataAnnotations;

namespace Athlitix.Utilities.Mappers;

public class ParticipantMapper : BaseMapper<ParticipantEntity, ParticipantModel>
{
    protected override void MapEntityToModel(ParticipantEntity entity, ParticipantModel model)
    {
        model.TeamId = entity.TeamId;
        model.FirstName = entity.FirstName;
        model.LastName = entity.LastName;
        model.NickName = entity.NickName;
        model.Email = entity.Email;
        model.PhoneNumber = entity.PhoneNumber;
        model.PasswordHash = entity.PasswordHash;
        model.HeightCm = entity.HeightCm;
        model.WeightKg = entity.WeightKg;
        model.DateOfBirth = entity.DateOfBirth;
    }

    protected override void MapModelToEntity(ParticipantModel model, ParticipantEntity entity)
    {
        entity.TeamId = model.TeamId;
        entity.FirstName = model.FirstName;
        entity.LastName = model.LastName;
        entity.NickName = model.NickName;
        entity.Email = model.Email;
        entity.PhoneNumber = model.PhoneNumber;
        entity.PasswordHash = model.PasswordHash;
        entity.HeightCm = model.HeightCm;
        entity.WeightKg = model.WeightKg;
        entity.DateOfBirth = model.DateOfBirth;
    }
}