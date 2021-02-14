using DataModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services;

namespace Machine_Cafe.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChoixUtilisateurController : ControllerBase
    {


        private readonly ILogger<ChoixUtilisateurController> _logger;

        private readonly ImachineService _machineService;

        public ChoixUtilisateurController(ILogger<ChoixUtilisateurController> logger, ImachineService machineService)
        {
            _logger = logger;
            _machineService = machineService;
        }

        [HttpGet]
        public Choix_utilisateurs Get(decimal badge)
        {

            var result = _machineService.GetUserChoice(badge);

            if (result != null)
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        [HttpPost]
        public IActionResult Post([FromBody] Choix_utilisateurs model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _machineService.PostDernierChoix(model);
            return Ok(model);
        }
    }
}
