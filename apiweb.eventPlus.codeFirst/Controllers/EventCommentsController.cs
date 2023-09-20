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
    public class EventCommentsController : ControllerBase
    {
        private readonly IEventCommentRepository _eventCommentRepository;

        public EventCommentsController()
        {
            _eventCommentRepository = new EventCommentRepository();
        }

        [HttpPost]
        public IActionResult Create(EventComment eventComment)
        {
            try
            {
                _eventCommentRepository.Create(eventComment);

                return StatusCode(201);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}
