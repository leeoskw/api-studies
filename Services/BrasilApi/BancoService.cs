using api_study.Dtos.BrasilApi;
using api_study.Models.BrasilApi;
using api_study.Repositories;

namespace api_study.Services
{
    public class BancoService
    {
        public  async Task<ResponseGenerico<EnderecoModel>> getEnderecoPorCep(string cep)
        {
            BrasilApiRepository brasilApi = new BrasilApiRepository();
            ResponseGenerico<EnderecoModel> dados = await brasilApi.getEnderecoPorCep(cep);
            return dados;
        }
    }
}
