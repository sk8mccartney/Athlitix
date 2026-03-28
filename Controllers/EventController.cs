using Athlitix.Controllers.Requests;
using Athlitix.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Athlitix.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EventController : ControllerBase
{
    private readonly IEventService _eventService;
    private readonly ILogger<EventController> _logger;

    public EventController(IEventService eventService, ILogger<EventController> logger)
    {
        _eventService = eventService;
        _logger = logger;
    }

    [HttpGet("{id}")]
    public IActionResult Get([FromRoute] Guid id)
    {
        try
        {
            var evt = _eventService.GetSingle(id);

            return Ok(evt);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Can not get event!");

            return BadRequest(ex.Message);
        }
    }

    [HttpPost("save")]
    public IActionResult Save([FromBody] EventRequest request)
    {
        try
        {
            //request.OrganizationId = request.OrganizationId;
            _eventService.Save(request);

            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Can not save event!");

            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public IActionResult Delete([FromRoute] Guid id)
    {
        try
        {
            _eventService.Delete(id);

            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);

            return BadRequest(ex.Message);
        }
    }
}