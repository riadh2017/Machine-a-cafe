using DataModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services;
using System.Collections.Generic;

namespace Machine_Cafe.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProduitController : ControllerBase
    {


        private readonly ILogger<ProduitController> _logger;

        private readonly ImachineService _machineService;

        public ProduitController(ILogger<ProduitController> logger, ImachineService machineService)
        {
            _logger = logger;
            _machineService = machineService;
        }

        [HttpGet]
        public List<Produits> Get()
        {

            var result = _machineService.GetProduits();
            return result;
        }
    }
}
