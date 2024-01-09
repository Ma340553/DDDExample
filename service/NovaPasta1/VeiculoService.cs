using Domain.commands;
using Domain.Enums;
using Domain.Interface;

namespace service.NovaPasta1
{
    public class VeiculoService : IVeiculoService
    {
        public void GetAsyns()
        {


        }

        public  async Task<string> PostAsync(VeiculoCommands command)
        {
            if (command == null)

                return "Todos comados são obrigatorios";

            int AnoAtual = DateTime.Now.Year;
            if ((AnoAtual - command.AnoFabricacao) > 5)
                return "O ano do veículo é menor que o permitido";




            if (command.TipoVeiculo != EtipoVeiculo.SUV
            && command.TipoVeiculo != EtipoVeiculo.Hatch
            && command.TipoVeiculo != EtipoVeiculo.Sedan
            )
                return "O tipo de veiculo não permitido";

            return "Cadastro Realizado com sucesso";

        }


        public void PostAsync()
        {

        }
    }
}
