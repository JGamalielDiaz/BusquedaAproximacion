using Microsoft.AspNetCore.Mvc;
using Services.ListasInterface;
using Services.ServiceList;

namespace API_LISTASRIESGO_BFP.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConsultaListaController : ControllerBase
    {
        private readonly IListas _listas;

        public ConsultaListaController(IListas _istas)
        {
            _listas = _istas;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string name)
        {
            var lista = await _listas.GetNameByAproximation(name);
            return Ok(lista);
        }
    }
}
