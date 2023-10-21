using api_study.Dtos.BrasilApi;
using api_study.Models;

namespace api_study.Interfaces.BrasilApi
{
    public interface IEndereco
    {
        Task<ResponseGenerico<EnderecoDTO>> getEnderecoPorCEP(string cep);
    }
}
