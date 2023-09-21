using apiweb.eventPlus.codeFirst.Domains;
using apiweb.eventPlus.codeFirst.Interfaces;
using apiweb.eventPlus.codeFirst.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace apiweb.eventPlus.codeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class EventPresencesController : ControllerBase
    {
        private readonly IEventPresenceRepository _eventPresenceRepository;

        public EventPresencesController()
        {
            _eventPresenceRepository = new EventPresenceRepository();
        }

        [HttpPost]
        public IActionResult Create(EventPresence eventPresence)
        {
            try
            {
                _eventPresenceRepository.Create(eventPresence);

                return StatusCode(201);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpGet]
        public IActionResult ListAll()
        {
            try
            {
                List<EventPresence> eventPresences = _eventPresenceRepository.ListAll();

                return Ok(eventPresences);  
            }
            catch (Exception err)
            {
                return BadRequest();
            }
        }

        [HttpDelete] 
        public IActionResult Delete(Guid id)
        {
            try
            {
                _eventPresenceRepository.Delete(id);

                return NoContent();
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpPut]
        public IActionResult Update(EventPresence eventPresence)
        {
            try
            {
                _eventPresenceRepository.Update(eventPresence);

                return NoContent();
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}
