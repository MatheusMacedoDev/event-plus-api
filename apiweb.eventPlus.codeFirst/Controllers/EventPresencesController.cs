﻿using apiweb.eventPlus.codeFirst.Domains;
using apiweb.eventPlus.codeFirst.Interfaces;
using apiweb.eventPlus.codeFirst.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace apiweb.eventPlus.codeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    [Authorize]
    public class EventPresencesController : ControllerBase
    {
        private readonly IEventPresenceRepository _eventPresenceRepository;

        public EventPresencesController()
        {
            _eventPresenceRepository = new EventPresenceRepository();
        }

        [HttpPost]
        [Authorize(Roles = "Comum")]
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
        [Authorize(Roles = "Administrador")]
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

        [HttpGet("{userId}")]
        [Authorize(Roles = "Comum")]
        public IActionResult ListByUserId(Guid userId)
        {
            try
            {
                List<EventPresence> userEventPresences = _eventPresenceRepository.ListByUserId(userId);

                return Ok(userEventPresences);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpDelete]
        [Authorize(Roles = "Comum")]
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
        [Authorize(Roles = "Comum")]
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
