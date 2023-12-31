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
    [Authorize]
    public class EventCommentsController : ControllerBase
    {
        private readonly IEventCommentRepository _eventCommentRepository;

        public EventCommentsController()
        {
            _eventCommentRepository = new EventCommentRepository();
        }

        [HttpPost]
        [Authorize(Roles = "Comum")]
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

        [HttpGet]
        [Authorize(Roles = "Administrador")]
        public IActionResult ListAll()
        {
            try
            {
                List<EventComment> eventComments = _eventCommentRepository.ListAll();

                return Ok(eventComments);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpGet("ListByEvent/{eventId}")]
        public IActionResult ListByEvent(Guid eventId)
        {
            try
            {
                List<EventComment> eventComments = _eventCommentRepository.ListByEvent(eventId);

                return Ok(eventComments);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }


        [HttpGet("{id}")]
        [Authorize(Roles = "Administrador")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                EventComment eventComment = _eventCommentRepository.GetById(id);

                return Ok(eventComment);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpDelete]
        [Authorize(Roles = "Administrador")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _eventCommentRepository.Delete(id);

                return NoContent();
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}
