using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CineHoytsBack.DataApi.Interfaces;
using CineHoytsBack.DataApi.Implementacion;
using CineHoytsBack.Dominio;
using Cine_Hoyts.Dominio;

namespace CineHoytsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TablasController : Controller
    {
        private IDataTables back;

        public TablasController()
        {
            back = new DataTable();
        }

        [HttpGet("GetDocumentos")]
        public IActionResult GetDoc()
        {
            try
            {
                return Ok(back.ObtenerTipoDoc());

            }
            catch
            {
                return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
            }
        }
        [HttpGet("FormaPago")]
        public IActionResult GetFP()
        {
            try
            {
                return Ok(back.ObtenerFormaPago());

            }
            catch
            {
                return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
            }
        }

        [HttpGet("ClientesCBO")]
        public IActionResult GetCLI()
        {
            try
            {
                return Ok(back.ObtenerClienteCbo());

            }
            catch
            {
                return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
            }
        }

        [HttpGet("VendedoresCBO")]
        public IActionResult Getvendedores()
        {
            try
            {
                return Ok(back.ObtenerVendedorCbo());

            }
            catch
            {
                return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
            }
        }

        [HttpGet("TipoCompraCBO")]
        public IActionResult GetTipoCompra()
        {
            try
            {
                return Ok(back.ObtenerTipoCompraCBO());

            }
            catch
            {
                return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
            }
        }

        [HttpGet("ProduccionCBO")]
        public IActionResult Getproduccion()
        {
            try
            {
                return Ok(back.ObtenerprudoccionCBO());

            }
            catch
            {
                return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
            }
        }

        [HttpGet("restriccionCBO")]
        public IActionResult Getrestric()
        {
            try
            {
                return Ok(back.ObtenerrestriccionCBO());

            }
            catch
            {
                return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
            }
        }

        [HttpGet("PeliculaCBO")]
        public IActionResult GetPelicula()
        {
            try
            {
                return Ok(back.ObtenerPeliculaCBO());

            }
            catch
            {
                return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
            }
        }

        [HttpPost("FechaCBO")]
        public IActionResult GetFecha(List<Parametro> pm)
        {
            if (pm is not null)
            {
                try
                {
                    return Ok(back.ObtenerFecha(pm));

                }
                catch
                {
                    return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
                }
            }
            else
            {
                return BadRequest("Debe cargar una lista de parametros");

            }




        }

        [HttpPost("HorarioCBO")]
        public IActionResult GetHorario(List<Parametro> pm)
        {
            if (pm is not null)
            {
                try
                {
                    return Ok(back.ObtenerHorario(pm));

                }
                catch
                {
                    return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
                }
            }
            else
            {
                return BadRequest("Debe cargar una lista de parametros");
            }

        }

        [HttpPost("IdiomaCBO")]
        public IActionResult GetIdioma(List<Parametro> pm)
        {
            if (pm is not null)
            {
                try
                {
                    return Ok(back.obteneridoma(pm));

                }
                catch
                {
                    return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
                }
            }
            else
            {
                return BadRequest("Debe cargar una lista de parametros");
            }


        }
        [HttpPost("SalaCBO")]
        public IActionResult Getsala(List<Parametro> pm)
        {
            if (pm is not null)
            {
                try
                {
                    return Ok(back.obtenerTipoSala(pm));

                }
                catch
                {
                    return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
                }
            }
            else
            {
                return BadRequest("Debe cargar una lista de parametros");

            }


        }

        [HttpPost("Funcion")]
        public IActionResult Getfun(List<Parametro> pm)
        {
            if (pm is not null)
            {
                try
                {
                    return Ok(back.obtenerFuncion(pm));

                }
                catch
                {
                    return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
                }
            }
            else
            {
                return BadRequest("Debe cargar una lista de parametros");
            }
        }

        [HttpGet("Entradas")]
        public IActionResult GetCantEntradas()
        {

            try
            {
                return Ok(back.obtenerFuncion());

            }
            catch
            {
                return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
            }

        }
        [HttpGet("Recaudado")]
        public IActionResult GetRecaudad()
        {

            try
            {
                return Ok(back.obtenerRecaudado());

            }
            catch
            {
                return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
            }
        }

        [HttpGet("Imagen")]
        public IActionResult GetImagen()
        {

            try
            {
                return Ok(back.obtenerImage());

            }
            catch
            {
                return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
            }
        }
        [HttpPost("BajarFuncion")]
        public IActionResult Baja(Parametro p)
        {
            if (p is not null)
            {
                try
                {
                    return Ok(back.Bajar_Fun(p));

                }
                catch
                {
                    return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
                }
            }
            else
            {
                return BadRequest("Debe cargar una lista de parametros");
            }
        }

        [HttpGet("GetProvincia")]
        public IActionResult GetProv()
        {

            try
            {
                return Ok(back.ObtenerProvincias());

            }
            catch
            {
                return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
            }
        }

        [HttpPost("GetLocalidad")]
        public IActionResult GetLocalidad(Parametro p )
        {
            if (p is not null)
            {
                try
                {
                    return Ok(back.ObtenerLocalidades(p));

                }
                catch
                {
                    return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
                }
            }
            else
            {
                return BadRequest("Debe cargar un parametro");

            }

        }

        [HttpGet("GetBarrio")]
        public IActionResult GetBarrio(int p)
        {

            try
            {
                return Ok(back.ObtenerBarrios(p));

            }
            catch
            {
                return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
            }
        }

        [HttpGet("PeliculaCbofun")]
        public IActionResult GetPeliculacrud()
        {
            try
            {
                return Ok(back.ObtenerPeliculaboCrud());

            }
            catch
            {
                return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
            }
        }

        [HttpGet("IdiomaCBO_crud_fun")]
        public IActionResult GetIdioma_fun()
        {
                try
                {
                    return Ok(back.ObtenerIdioma_cbo_fun());

                }
                catch
                {
                    return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
                }
        }


        [HttpGet("HorarioCboFun")]
        public IActionResult GetHorarioFun()
        {
            try
            {
                return Ok(back.ObtenerHorario_cbo_fun());

            }
            catch
            {
                return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
            }
        }

        [HttpGet("SalaFun")]
        public IActionResult GETSALA()
        {
            try
            {
                return Ok(back.obtenerTipoSalacbo());

            }
            catch
            {
                return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
            }
        }

        [HttpGet("Fun")]
        public IActionResult GetFunciones()
        {
            try
            {
                return Ok(back.ObtenerFunciones());

            }
            catch
            {
                return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
            }
        }

        [HttpGet("BajaFun")]
        public IActionResult BajarFun(int a)
        {
            try
            {
                return Ok(back.Bajar_Fun(a));

            }
            catch
            {
                return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
            }
        }

        [HttpPost("AltaFun")]
        public IActionResult AltaFun(Funcion a)
        {
            try
            {
                return Ok(back.Alta_Fun(a));

            }
            catch
            {
                return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
            }
        }

        [HttpPost("UpdateFun")]
        public IActionResult UpdateFun(Funcion a)
        {

                return Ok(back.Update_Fun(a));

        }
        [HttpGet("BuscarFun")]
        public IActionResult BuscarFun(int a)
        {
            try
            {
                return Ok(back.buscar_fun(a));

            }
            catch
            {
                return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
            }
        }
    }
}
