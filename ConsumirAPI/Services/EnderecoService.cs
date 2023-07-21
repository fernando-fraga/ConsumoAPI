using AutoMapper;
using ConsumirAPI.Dtos;
using ConsumirAPI.Interfaces;
using ConsumirAPI.Models;

namespace ConsumirAPI.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public EnderecoService(IMapper mapper, IBrasilApi brasilApi) {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep) {
            var endereco = await _brasilApi.BuscarEnderecoPorCep(cep);

            return _mapper.Map<ResponseGenerico<EnderecoResponse>>(endereco);


        }
    }
}
