using AutoMapper;
using ConsumirAPI.Dtos;
using ConsumirAPI.Models;

namespace ConsumirAPI.Mappings
{
    public class EnderecoMapping : Profile
    {
        public EnderecoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>),typeof(ResponseGenerico<>));
            CreateMap<EnderecoResponse, EnderecoModel>();
            CreateMap<EnderecoModel, EnderecoResponse>();

        }
    }
}
