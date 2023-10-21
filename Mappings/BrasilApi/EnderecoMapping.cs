using api_study.Dtos.BrasilApi;
using api_study.Models.BrasilApi;
using AutoMapper;

namespace api_study.Mappings.BrasilApi
{
    public class EnderecoMapping : Profile
    {
        public EnderecoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<EnderecoDTO, EnderecoModel>();
            CreateMap<EnderecoModel, EnderecoDTO>();

        }
    }
}
