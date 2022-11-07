using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CineHoytsBack.DataApi.Implementacion;
using CineHoytsBack.DataApi.Interfaces;
using Cine_Hoyts.Dominio;

namespace CineHoytsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CRUDvendedor : Controller
    {
        private IDATACRUDvendedor back;
        public CRUDvendedor()
        {
            back = new DATACRUDvendedor();
        }
        [HttpGet("GetVendedor")]
        public IActionResult GetVen()
        {
            try
            {
                return Ok(back.Cargar_Vendedores());

            }
            catch (Exception)
            {
                return BadRequest("Error del servidor, intentelo de nuevo más tarde");
            }
        }

        [HttpGet("BajaVendedor")]
        public IActionResult BajaVen(int a)
        {
            try
            {
                return Ok(back.baja(a));

            }
            catch (Exception)
            {
                return BadRequest("Error del servidor, intentelo de nuevo más tarde");
            }
        }

        [HttpPost("PostAltaVendedor")]
        public IActionResult PostAlta(Vendedor c)
        {
            if (c is not null)
            {
                try
                {
                    return Ok(back.alta(c));

                }
                catch (Exception)
                {
                    return BadRequest("Error del servidor, intentelo de nuevo más tarde");
                }
            }
            else
            {
                return BadRequest("Debe cargar un cliente");
            }

        }

        [HttpPost("PutModificarVendedor")]
        public IActionResult PutModificar(Vendedor c)
        {
            if (c is not null)
            {
                try
                {
                    return Ok(back.Modificacion(c));

                }
                catch (Exception)
                {
                    return BadRequest("Error del servidor, intentelo de nuevo más tarde");
                }
            }
            else
            {
                return BadRequest("Debe Cargar un cliente");

            }

        }

        [HttpGet("GetExisteVendedor")]
        public IActionResult GetExisteCliente(int c)
        {
            try
            {
                return Ok(back.search_Vendedor(c));

            }
            catch (Exception)
            {
                return BadRequest("Error del servidor, intentelo de nuevo más tarde");
            }
        }
    }
}
