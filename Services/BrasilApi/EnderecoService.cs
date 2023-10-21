using api_study.Dtos.BrasilApi;
using api_study.Interfaces.BrasilApi;
using api_study.Models;
using AutoMapper;

namespace api_study.Services
{
    public class EnderecoService : IEndereco
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;


        public EnderecoService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<EnderecoDTO>> getEnderecoPorCEP(string cep)
        {
            var endereco = await _brasilApi.getEnderecoPorCep(cep);
            return _mapper.Map<ResponseGenerico<EnderecoDTO>>(endereco);
            //return endereco;
        }

        //public async Task<ResponseGenerico<EnderecoModel>> getEnderecoPorCEP(string cep)
        //{
        //    return await _brasilApi.getEnderecoPorCep(cep);
        //}
    }
}
