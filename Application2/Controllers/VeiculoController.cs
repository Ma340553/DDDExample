using Domain.commands;
using Domain.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        private readonly IVeiculoService _veiculoService;
        public VeiculoController(IVeiculoService veiculoService)
        {
            _veiculoService = veiculoService;
        }

        [HttpPost]

        [Route("CadastrarVeiculo")]
        public async Task<IActionResult> PostAsy([FromBody] VeiculoCommands command)
        {
           
            return Ok(await _veiculoService.PostAsync(command));
        }
        [HttpGet]
        [Route("SimularAluguel")]
        public IActionResult postAsync()
        {
            return Ok();
      
        }
        [HttpPost]
        [Route("Alugar")]
        public IActionResult PostAsync()
        {
            return Ok();
        }
    }
}


