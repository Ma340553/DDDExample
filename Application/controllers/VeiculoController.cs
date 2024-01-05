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
        public IActionResult postAsync([FromBody] VeiculoCommands command)
        {
            _veiculoService.PostAsync(command);
            return Ok();
        }
        [HttpGet]
        [Route("SimularAluguel")]
        public IActionResult postAsyn()
        {
            return Ok();
      
        }
        [HttpPost]
        [Route("Alugar")]
        public IActionResult postAsync()
        {
            return Ok();
        }
    }
}


