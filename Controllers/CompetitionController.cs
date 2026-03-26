using Athlitix.Controllers.Requests;
using Athlitix.Models;
using Athlitix.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Athlitix.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CompetitionController : ControllerBase
{
    private readonly ICompetitionService _competitionService;
    private readonly ILogger<CompetitionController> _logger;

    public CompetitionController(ICompetitionService competitionService, ILogger<CompetitionController> logger)
    {
        _competitionService = competitionService;
        _logger = logger;
    }

    [HttpGet("{id}")]
    public IActionResult Get([FromRoute] Guid id)
    {
        try
        {
            var competition = _competitionService.GetSingle(id);

            return Ok(competition);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Can not get competition!");

            return BadRequest(ex.Message);
        }
    }

    [HttpPost("save")]
    public IActionResult Save([FromBody]CompetitionRequest request)
    {
        try
        {
            request.OrganizationId = request.OrganizationId;
            _competitionService.Save(request);

            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Can not save competition!");

            return BadRequest(ex.Message);
        }
    }
}