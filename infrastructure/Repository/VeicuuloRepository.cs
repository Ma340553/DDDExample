using Dapper;
using Domain.entidades;
using Domain.Interface;
using Microsoft.Data.SqlClient;

namespace infrastructure.Repository
{
    internal class VeicuuloRepository : IVeiculoRepository
    {
        private string stringconnection = "";

        public void GetAsyns()
        {
            throw new NotImplementedException();
        }
        public async Task<string> PostAsync(Veiculo command)
        {
            string queryInsert = @"Insert into Veiculo(Placa,AnoFabricacao,TipoVeiculo,Estado,	MontadoraId)
                                    Values(@Placa, @AnoFabricacao , @TipoVeiculo, @Estado, @Montadora)
";

            using (var conn = new SqlConnection())
            {
                conn.Execute(queryInsert, new
                {
                    Placa = command.Placa,
                    AnoFabricacao = command.AnoFabricacao,
                    TipoVeiculo = command.TipoVeiculo,
                    Estado = command.Estado,
                    MontadoraId = command.Montadora
                });
                return "Veiculo Castrado com sucesso";
            }
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}
