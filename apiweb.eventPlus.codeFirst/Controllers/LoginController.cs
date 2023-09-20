using apiweb.eventPlus.codeFirst.Domains;
using apiweb.eventPlus.codeFirst.Interfaces;
using apiweb.eventPlus.codeFirst.Repositories;
using apiweb.eventPlus.codeFirst.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

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

                // Create token

                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Jti, findedUser.Id.ToString()),
                    new Claim(JwtRegisteredClaimNames.Email, findedUser.Email!),
                    new Claim(ClaimTypes.Role, findedUser.UserType!.TypeName!)
                };

                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("event-plus-authentication-webapi-dev"));

                var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(issuer: "apiweb.eventPlus.codeFirst", audience: "apiweb.eventPlus.codeFirst", claims: claims, expires: DateTime.Now.AddMinutes(5), signingCredentials: credentials);

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}
