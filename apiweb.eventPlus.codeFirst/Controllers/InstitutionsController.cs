using apiweb.eventPlus.codeFirst.Domains;
using apiweb.eventPlus.codeFirst.Interfaces;
using apiweb.eventPlus.codeFirst.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace apiweb.eventPlus.codeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class InstitutionsController : ControllerBase
    {
        private readonly IInstitutionRepository _institutionRepository;

        public InstitutionsController()
        {
            _institutionRepository = new InstitutionRepository();
        }

        [HttpPost]
        public IActionResult Create(Institution institution)
        {
            try
            {
                _institutionRepository.Create(institution);

                return StatusCode(201);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}
