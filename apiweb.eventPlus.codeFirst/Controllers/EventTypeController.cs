using apiweb.eventPlus.codeFirst.Domains;
using apiweb.eventPlus.codeFirst.Interfaces;
using apiweb.eventPlus.codeFirst.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiweb.eventPlus.codeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class EventTypeController : ControllerBase
    {
        private readonly IEventTypeRepository _eventTypeRepository;

        public EventTypeController()
        {
            _eventTypeRepository = new EventTypeRepository();
        }

        [HttpPost]
        public IActionResult Create(EventType eventType)
        {
            try
            {
                _eventTypeRepository.Create(eventType);

                return StatusCode(201);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}
