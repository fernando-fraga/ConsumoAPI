using ConsumirAPI.Dtos;
using ConsumirAPI.Models;

namespace ConsumirAPI.Interfaces
{
    public interface IEnderecoService
    {
        Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep);

    }
}
