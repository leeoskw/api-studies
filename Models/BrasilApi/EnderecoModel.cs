using System.Text.Json.Serialization;

namespace api_study.Models.BrasilApi
{
    public class EnderecoModel
    {
        public string? cep { get; set; }
        [JsonPropertyName("state")]
        public string? estado { get; set; }
        [JsonPropertyName("city")]
        public string? cidade { get; set; }
        [JsonPropertyName("neighborhood")]
        public string? bairro { get; set; }
        [JsonPropertyName("street")]
        public string? rua { get; set; }
        [JsonPropertyName("service")]
        public string? servico { get; set; }
    }
}
