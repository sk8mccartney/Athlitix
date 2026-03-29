using Athlitix.Controllers.Requests;
using Athlitix.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Athlitix.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TeamController : ControllerBase
{
    private readonly ITeamService _teamService;
    private readonly ILogger<TeamController> _logger;

    public TeamController(ITeamService teamService, ILogger<TeamController> logger)
    {
        _teamService = teamService;
        _logger = logger;
    }

    [HttpGet("{id}")]
    public IActionResult Get([FromRoute] Guid id)
    {
        try
        {
            var team = _teamService.GetSingle(id);

            return Ok(team);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Can not get team!");

            return BadRequest(ex.Message);
        }
    }

    [HttpPost("save")]
    public IActionResult Save([FromBody] TeamRequest request)
    {
        try
        {
            request.OrganizationId = request.OrganizationId;
            _teamService.Save(request);

            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Can not save team!");

            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public IActionResult Delete([FromRoute] Guid id)
    {
        try
        {
            _teamService.Delete(id);

            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);

            return BadRequest(ex.Message);
        }
    }
}