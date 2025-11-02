using Athlitix.Configuration;
using Athlitix.Data;
using Athlitix.Entities;
using Athlitix.Models;
using Athlitix.Services.Interfaces;
using Athlitix.Utilities.Mappers;
using Microsoft.Extensions.Options;

namespace Athlitix.Services;

public class AdminService : IAdminService
{
    private readonly AthlitixContext _dbContext;
    private readonly ILogger<AdminService> _logger;
    private readonly string _salt;
    private readonly IMapper<AdminEntity, AdminModel> _mapper;

    public AdminService(AthlitixContext dbContext, ILogger<AdminService> logger, IOptions<SecuritySettings> securityOptions, IMapper<AdminEntity, AdminModel> mapper)
    {
        _dbContext = dbContext;
        _logger = logger;
        _salt = securityOptions.Value.PasswordSalt ?? throw new InvalidOperationException("Missing salt in configuration.");
        _mapper = mapper;
    }

    public AdminModel Add(AdminModel adminModel)
    {
        if (string.IsNullOrEmpty(adminModel.FirstName)) throw new ArgumentNullException(nameof(adminModel.FirstName));
        if (string.IsNullOrEmpty(adminModel.LastName)) throw new ArgumentNullException(nameof(adminModel.LastName));
        if (string.IsNullOrEmpty(adminModel.Email)) throw new ArgumentNullException(nameof(adminModel.Email));
        if (string.IsNullOrEmpty(adminModel.PhoneNumber)) throw new ArgumentNullException(nameof(adminModel.PhoneNumber));

        _logger.LogInformation("Create admin {admin}.", $"{adminModel.FirstName} {adminModel.LastName}");

        var admin = _dbContext.Admins.Add(_mapper.ToEntity(adminModel));
        _dbContext.SaveChanges();

        return _mapper.ToModel(admin.Entity);
    }

    public AdminModel GetSingle(Guid id)
    {
        _logger.LogInformation("Retrieving admin {adminId}.", id);
        var admin = _dbContext.Admins.Single(x => x.Id == id);

        _logger.LogInformation("Retrived admin {name}.", $"{admin.FirstName} {admin.LastName}");
        return _mapper.ToModel(admin);
    }

    public AdminModel? Login(string email, string password)
    {
        if (string.IsNullOrEmpty(email))
        {
            throw new ArgumentNullException(nameof(email));
        }

        if (string.IsNullOrEmpty(password))
        {
            throw new ArgumentNullException(nameof(password));
        }

        try
        {
            _logger.LogInformation("Login request for {email}.", email);
            var admin = _dbContext.Admins.Single(x => x.Email.Equals(email) && x.PasswordHash.Equals(Utility.PasswordHasher.HashPassword(password, _salt)));

            _logger.LogInformation("Login successful for {email}.", admin.Email);
            return _mapper.ToModel(admin);
        }
        catch (InvalidOperationException)
        {
            _logger.LogWarning("Invalid login attempt for {email}.", email);
            return null; // or throw a custom AuthenticationException
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unexpected error during login for {email}.", email);
            throw; // rethrow or wrap in a custom exception
        }
    }
}