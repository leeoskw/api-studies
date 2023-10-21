using api_study.Dtos.BrasilApi;
using api_study.Models.BrasilApi;

namespace api_study.Interfaces.BrasilApi
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<EnderecoModel>> getEnderecoPorCep(string cep);
        Task<ResponseGenerico<BancoModel>> getBanco(string codigoBanco);
        Task<ResponseGenerico<List<BancoModel>>> getBancos();
    }
}
