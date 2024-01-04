using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.commands
{
    public class VeiculoCommands
    {
       
        public int VeiculoID { get; set; }

        public string Placa { get; }

        public int AnoFabricacao { get; set; }

        public EtipoVeiculo TipoVeiculo { get; set; }
        public string Estado { get; set; }

        public EMontadora MONTADORA { get; set; }

        public bool Alugado { get; set; }
    }
}