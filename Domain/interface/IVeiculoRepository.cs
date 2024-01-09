using Domain.entidades;

namespace Domain.Interface
{
    public interface IVeiculoRepository
    {
        //A interface é um contrato, apenas usamos para adicionar
        //metodos,
        //não é feita implementação de nada

        Task<string> PostAsync(Veiculo  command);
        void PostAsync();
        void GetAsyns();
    }
}
