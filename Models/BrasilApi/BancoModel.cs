using System.Text.Json.Serialization;

namespace api_study.Models.BrasilApi
{
    public class BancoModel
    {
        public string? ispb { get; set; }
        [JsonPropertyName("name")]
        public string? nome { get; set; }
        [JsonPropertyName("code")]
        public string? codigo { get; set; }
        [JsonPropertyName("fullName")]
        public string? nomeCompleto { get; set; }
    }
}
