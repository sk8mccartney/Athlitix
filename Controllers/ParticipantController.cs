using Athlitix.Controllers.Requests;
using Athlitix.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Athlitix.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ParticipantController : ControllerBase
{
    private readonly IParticipantService _participantService;
    private readonly ILogger<ParticipantController> _logger;

    public ParticipantController(IParticipantService participantService, ILogger<ParticipantController> logger)
    {
        _participantService = participantService;
        _logger = logger;
    }

    [HttpGet("{id}")]
    public IActionResult Get([FromRoute] Guid id)
    {
        try
        {
            var evt = _participantService.GetSingle(id);

            return Ok(evt);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Can not get participant!");

            return BadRequest(ex.Message);
        }
    }

    [HttpPost("save")]
    public IActionResult Save([FromBody] ParticipantRequest request)
    {
        try
        {
            //request.OrganizationId = request.OrganizationId;
            _participantService.Save(request);

            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Can not save participant!");

            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public IActionResult Delete([FromRoute] Guid id)
    {
        try
        {
            _participantService.Delete(id);

            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);

            return BadRequest(ex.Message);
        }
    }
}