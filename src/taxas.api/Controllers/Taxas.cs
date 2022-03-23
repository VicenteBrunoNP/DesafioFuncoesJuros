using Microsoft.AspNetCore.Mvc;

namespace taxas.api.Controllers
{
    [ApiController]
    public class TaxasController : ControllerBase
    {
        [HttpGet]
        [Route("taxaJuros")]
        public double TaxaJuros()
        {
            return 0.01;
        }
    }
}