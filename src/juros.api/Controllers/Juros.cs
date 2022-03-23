using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using juros.api.Services;

namespace juros.api.Controllers
{
    [ApiController]
    //[Route("v1")]
    public class JurosController : ControllerBase
    {
        [HttpGet]
        [Route("calculajuros")]
        public IActionResult Calculajuros([FromQuery] decimal valorinicial, [FromQuery] int meses)
        {
            double valorFinal = 0;
            double taxaJuros = ServiceTaxaJuros.BuscaTaxaJuros();

            try
            {
                if (valorinicial <= 0)
                    return NotFound("Valor inicial não pode ser menor ou inferior 0");

                if (meses <= 0)
                    return NotFound("Meses não pode ser menor ou inferior");

                valorFinal = (double)valorinicial * (Math.Pow(1 + taxaJuros, meses));
                valorFinal = Math.Round(valorFinal, 2);
            }
            catch (Exception)
            {
                return NotFound();
            }

            return Ok(valorFinal);
        }

        [HttpGet]
        [Route("showmethecode")]
        public string Showmethecode()
        {
            return "https://github.com/VicenteBrunoNP/DesafioFuncoesJuros";
        }
    }
}