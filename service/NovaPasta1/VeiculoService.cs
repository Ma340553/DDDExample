using Domain.commands;
using Domain.Enums;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service.NovaPasta1
{
    public class VeiculoService : IVeiculoService
    {
        public void GetAsyns()
        {
            throw new NotImplementedException();

        }

        public Task PostAsync(VeiculoCommands command)
        {
            if (command == null)
            
                throw new NotImplementedException();
            
            if(command.TipoVeiculo != EtipoVeiculo.SUV
            &&command.TipoVeiculo != EtipoVeiculo.Hatch
            &&command.TipoVeiculo != EtipoVeiculo.Sedan
            )

                            throw new NotImplementedException();

        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}
