using Cine_Hoyts.Dominio;
using CineHoytsBack.DataApi.Implementacion;
using CineHoytsBack.DataApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CineHoytsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private IDataLogin back;

        public LoginController()
        {
            back = new DataLogin();
        }

        [HttpPost("GetLoged")]
        public IActionResult GetLoged(Vendedor v)
        {
            if (v is not null)
            {
                try
                {
                    return Ok(back.Logeado(v));

                }
                catch (Exception)
                {
                    return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
                }
            }
            else
            {
                return BadRequest("Debe cargar un vendedor");

            }

        }

        [HttpPost("GetDatos")]
        public IActionResult GetDatos(Vendedor v)
        {
            if (v is not null)
            {
                try
                {
                    return Ok(back.GetDatos(v));

                }
                catch (Exception)
                {
                    return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");

                }
            }
            else
            {
                return BadRequest("Debe cargar un vendedor");

            }

        }
    }
}
