using Microsoft.AspNetCore.Mvc;
using TesteWebAPI.Models;

namespace TesteWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ConversorDistanciasController : Controller
    {
        [HttpGet("MilhasKm/{distanciaMilhas}")]
        public Distancia ConverterMilhasParaKm(double distanciaMilhas)
        {
            Distancia distancia = new Distancia();
            distancia.ValorMilhas = distanciaMilhas;
            distancia.ValorKm = distanciaMilhas * 1.609;

            return distancia;
        }
    }
}