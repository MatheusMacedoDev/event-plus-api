using apiweb.eventPlus.codeFirst.Domains;
using apiweb.eventPlus.codeFirst.Interfaces;
using apiweb.eventPlus.codeFirst.Repositories;
using apiweb.eventPlus.codeFirst.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiweb.eventPlus.codeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class LoginController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public LoginController()
        {
            _userRepository = new UserRepository();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel userData)
        {
            try
            {
                User findedUser = _userRepository.GetByEmailAndPassword(userData.Email!, userData.Password!);

                if (findedUser == null)
                {
                    return NotFound("Dados inválidos");
                }

                return Ok(findedUser);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}
