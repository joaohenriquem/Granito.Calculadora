using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Taxas.Application.Taxas;

namespace Taxas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaxasController : ControllerBase
    {
        private readonly ILogger<TaxasController> _logger;

        private ITaxasApplication _taxasService { get; set; }

        public TaxasController(ILogger<TaxasController> logger, ITaxasApplication taxasService)
        {
            _logger = logger;
            _taxasService = taxasService;
        }

        [HttpGet]
        [MapToApiVersion("1.0")]
        [Route("ObterTaxa")]
        public IActionResult ObterTaxa()
        {
            var response = _taxasService.ObterTaxa();
            return StatusCode(StatusCodes.Status201Created, response);
        }
    }
}
