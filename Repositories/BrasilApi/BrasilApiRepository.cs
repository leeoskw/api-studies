using api_study.Dtos.BrasilApi;
using api_study.Interfaces.BrasilApi;
using api_study.Models.BrasilApi;
using System.Dynamic;
using System.Text.Json;

namespace api_study.Repositories
{
    public class BrasilApiRepository : IBrasilApi
    {
        public Task<ResponseGenerico<List<BancoModel>>> getBancos()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseGenerico<BancoModel>> getBanco(string codigoBanco)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseGenerico<EnderecoModel>> getEnderecoPorCep(string cep)
        {
            string apiBrasilUrl = $"https://brasilapi.com.br/api/cep/v1/{cep}";
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, apiBrasilUrl);
            HttpClient client = new HttpClient();

            var response = new ResponseGenerico<EnderecoModel>();
            var responseBrasilApi = await client.SendAsync(request);
            string data = await responseBrasilApi.Content.ReadAsStringAsync();
            EnderecoModel objResponse = JsonSerializer.Deserialize<EnderecoModel>(data);

            if (responseBrasilApi.IsSuccessStatusCode)
            {
                response.codigoHttp = responseBrasilApi.StatusCode;
                response.dados = objResponse;
                return response;
            }
            response.codigoHttp = responseBrasilApi.StatusCode;
            response.erroRetornoApi = JsonSerializer.Deserialize<ExpandoObject>(data);
            return response;
        }
    }
}
