﻿using apiweb.eventPlus.codeFirst.Domains;
using apiweb.eventPlus.codeFirst.Interfaces;
using apiweb.eventPlus.codeFirst.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiweb.eventPlus.codeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UserTypesController : ControllerBase
    {
        private readonly IUserTypeRepository _userTypeRepository;

        public UserTypesController()
        {
            _userTypeRepository = new UserTypesRepository();
        }

        [HttpPost]
        public IActionResult Create(UserType userType)
        {
            try
            {
                _userTypeRepository.Create(userType);

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
                List<UserType> userTypes = _userTypeRepository.ListAll();

                return Ok(userTypes);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}
