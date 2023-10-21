using System.Text.Json.Serialization;

namespace api_study.Dtos.BrasilApi
{
    public class EnderecoDTO
    {
        public string? cep { get; set; }
        public string? estado { get; set; }
        public string? cidade { get; set; }
        public string? bairro { get; set; }
        public string? rua { get; set; }
    }
}
