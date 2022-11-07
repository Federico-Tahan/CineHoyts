using Microsoft.AspNetCore.Mvc;
using CineHoytsBack.DataApi.Interfaces;
using CineHoytsBack.DataApi.Implementacion;
using CineHoytsBack.Dominio;

namespace CineHoytsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Reportes : Controller
    {
        private IDataReportes back;

        public Reportes()
        {
            back = new DataReportes();
        }
        [HttpGet("GastoTotalClientes")]
        public IActionResult GastoTotalClientes()
        {
            try
            {
                return Ok(back.ClientesPromGasto());

            }
            catch (Exception)
            {
                return BadRequest("Error del servidor, intentelo de nuevo más tarde");
            }
        }
        [HttpGet("Gasto")]
        public IActionResult Gasto()
        {
            try
            {
                return Ok(back.gasto());

            }
            catch (Exception)
            {
                return BadRequest("Error del servidor, intentelo de nuevo más tarde");
            }
        }
        [HttpGet("VentaXTicket")]
        public IActionResult TicketxVendedor()
        {
            try
            {
                return Ok(back.Cargar_Clientes_ConVentas());

            }
            catch (Exception)
            {
                return BadRequest("Error del servidor, intentelo de nuevo más tarde");
            }
        }

        [HttpGet("MayMen")]
        public IActionResult MayMen()
        {
            try
            {
                return Ok(back.maymenGasto());

            }
            catch (Exception)
            {
                return BadRequest("Error del servidor, intentelo de nuevo más tarde");
            }
        }

        [HttpGet("gananciaxpeli")]
        public IActionResult Gananciaxpeli()
        {
            try
            {
                return Ok(back.gananciaxpeli());

            }
            catch (Exception)
            {
                return BadRequest("Error del servidor, intentelo de nuevo más tarde");
            }
        }

        [HttpGet("espect")]
        public IActionResult getcantentrada(int a)
        {
            try
            {
                return Ok(back.Espxpel(a));

            }
            catch (Exception)
            {
                return BadRequest("Error del servidor, intentelo de nuevo más tarde");
            }
        }

        [HttpGet("rec")]
        public IActionResult s()
        {
            try
            {
                return Ok(back.rec());

            }
            catch (Exception)
            {
                return BadRequest("Error del servidor, intentelo de nuevo más tarde");
            }
        }

        [HttpPost("Postclienterecau")]
        public IActionResult s(List<Parametro> p)
        {
            try
            {
                return Ok(back.TotalDeclientes(p));

            }
            catch (Exception)
            {
                return BadRequest("Error del servidor, intentelo de nuevo más tarde");
            }
        }
    }
}
