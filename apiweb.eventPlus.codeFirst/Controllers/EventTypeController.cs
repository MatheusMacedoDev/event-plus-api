﻿using apiweb.eventPlus.codeFirst.Domains;
using apiweb.eventPlus.codeFirst.Interfaces;
using apiweb.eventPlus.codeFirst.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace apiweb.eventPlus.codeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    [Authorize(Roles = "Administrador")]
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

        [HttpGet]
        public IActionResult ListAll()
        {
            try
            {
                List<EventType> eventTypes = _eventTypeRepository.ListAll();

                return Ok(eventTypes);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                EventType eventType = _eventTypeRepository.GetById(id);

                return Ok(eventType);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpPut]
        public IActionResult Update(EventType eventType)
        {
            try
            {
                _eventTypeRepository.Update(eventType);

                return NoContent();
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _eventTypeRepository.Delete(id);

                return NoContent();
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}
