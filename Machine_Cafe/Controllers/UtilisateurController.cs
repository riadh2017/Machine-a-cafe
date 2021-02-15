using DataModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Machine_Cafe.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UtilisateurController : ControllerBase
    {
        private readonly ILogger<UtilisateurController> _logger;

        private readonly ImachineService _machineService;

        public UtilisateurController(ILogger<UtilisateurController> logger, ImachineService machineService)
        {
            _logger = logger;
            _machineService = machineService;
        }

        [HttpGet]
        public JsonResult Get(decimal badge)
        {

            var result = _machineService.GetUser(badge);

            if(result != null)
            {
                return new JsonResult(result);
            }
            else
            {
                return new JsonResult(null);
            }
        }

 


    }
}
