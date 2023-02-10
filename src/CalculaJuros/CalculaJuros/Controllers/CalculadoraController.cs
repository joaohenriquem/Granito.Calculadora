using CalculaJuros.Application.Calculo;
using CalculaJuros.Core.Calculo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CalculaJuros.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculadoraController : ControllerBase
    {
        private readonly ILogger<CalculadoraController> _logger;

        private  IJurosApplication _jurosCompostosService { get; set; }

        public CalculadoraController(ILogger<CalculadoraController> logger, IJurosApplication jurosCompostosService)
        {
            _logger = logger;
            _jurosCompostosService = jurosCompostosService;
        }

        [HttpGet]
        [MapToApiVersion("1.0")]
        [Route("CalculaJuros")]
        public IActionResult CalculaJuros([FromQuery] double valorInicial, int meses)
        {
            if (ModelState.IsValid)
            {
                var input = new JurosCompostos
                {
                    valorInicial = valorInicial,
                    meses = meses
                };

                var response = _jurosCompostosService.CalculaJurosCompostos(input);

                return StatusCode(StatusCodes.Status200OK, response);
            }

            return StatusCode(StatusCodes.Status500InternalServerError, null);
        }

        [HttpGet]
        [MapToApiVersion("1.0")]
        [Route("ShowMeTheCode")]
        public IActionResult ShowMeTheCode()
        {
            return StatusCode(StatusCodes.Status201Created, new { Url = "https://github.com/joaohenriquem/Granito.Calculadora" });
        }
    }
}
