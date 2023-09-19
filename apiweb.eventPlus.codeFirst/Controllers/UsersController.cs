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
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsersController()
        {
            _userRepository = new UserRepository();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            try
            {
                _userRepository.Register(user);

                return StatusCode(201);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}
