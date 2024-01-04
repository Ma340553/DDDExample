using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {

        [HttpPost("cadastrarVeiculo")]

        public IActionResult postAsync([FromBody] VeiculoCommand command)
        {
            return Ok();
        }
        public IActionResult SimularAluguel()
        {
            return Ok();
        }
        public IActionResult Alugar()
        {
            return Ok();
        }
    }
}


