using Athlitix.Data.Model;
using Athlitix.Services.Models;

namespace Athlitix.Services.Extensions;

public static class AdminExtensions
{
    public static AdminModel ToModel(this Admin admin) => new AdminModel
    {
        FirstName = admin.FirstName,
        LastName = admin.LastName,
        PhoneNumber = admin.PhoneNumber,
        Email = admin.Email,
        Id = admin.Id,
        CreatedAt = admin.CreatedAt,
        CreatedBy = admin.CreatedBy,
        ModifiedAt = admin.ModifiedAt,
        ModifiedBy = admin.ModifiedBy
    };

    public static Admin ToEntity(this AdminModel model) => new Admin
    {
        FirstName = model.FirstName,
        LastName = model.LastName,
        PhoneNumber = model.PhoneNumber,
        Email = model.Email,
        Id = model.Id,
        CreatedAt = model.CreatedAt,
        CreatedBy = model.CreatedBy,
        ModifiedAt = model.ModifiedAt,
        ModifiedBy = model.ModifiedBy
    };
}
