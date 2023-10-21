using api_study.Dtos;
using api_study.Interfaces.BrasilApi;
using api_study.Models;
using api_study.Services;
using Microsoft.AspNetCore.Mvc;

namespace api_study.Controllers
{
    [ApiController]
    [Route("brasilapi")]
    public class BrasilApiController : ControllerBase
    {

        public readonly IEndereco _endereco;

        public BrasilApiController(IEndereco endereco)
        {
            _endereco = endereco;
        }


        [HttpGet]
        [Route("buscar/endereco/{cep}")]
        public  async Task<IActionResult> getEndereco([FromRoute] string cep)
        {
            //BancoService bancoService = new BancoService();
            //var dados =   await bancoService.getEnderecoPorCep(cep);
            var response = await _endereco.getEnderecoPorCEP(cep);


            if (response.codigoHttp == System.Net.HttpStatusCode.OK)
            {
                return Ok(response.dados);
            }
            return StatusCode((int)response.codigoHttp, response.erroRetornoApi);
        }
    }
}
