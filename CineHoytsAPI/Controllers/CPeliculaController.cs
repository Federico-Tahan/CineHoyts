using Cine_Hoyts.Datos.Implementacion;
using Cine_Hoyts.Dominio;
using CineHoytsBack.DataApi.Implementacion;
using CineHoytsBack.DataApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CineHoytsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CPeliculaController : Controller
    {
        private IDataPelicula back;

        public CPeliculaController()
        {
            back = new DataPelicula();
        }

        [HttpGet("PeliculaGet")]
        public IActionResult GetPelicula()
        {

                return Ok(back.peliculas());
        }

        [HttpGet("PeliculaFilterGet")]
        public IActionResult GetPeliculaFilter(string nombre)
        {

            return Ok(back.peliculas_filter(nombre));
        }

        [HttpGet("PeliculasCrud")]
        public IActionResult GetPeliculaCrud()
        {

            return Ok(back.peliculas_Crud());
        }
        [HttpGet("BajarPel")]
        public IActionResult BajarPel(int a)
        {

            return Ok(back.BajaPel(a));
        }

        [HttpGet("SearchPel")]
        public IActionResult Buscarpel(int a)
        {

            return Ok(back.BuscarPel(a));
        }


        [HttpPost("Modificar_Pel")]
        public IActionResult PutModificar(Pelicula c)
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
                return BadRequest("Debe Cargar una Pelicula");

            }

        }

        [HttpPost("Insert_Pel")]
        public IActionResult InsertarPel(Pelicula c)
        {
            if (c is not null)
            {
                try
                {
                    return Ok(back.AltaPeli(c));

                }
                catch (Exception)
                {
                    return BadRequest("Error del servidor, intentelo de nuevo más tarde");
                }
            }
            else
            {
                return BadRequest("Debe Cargar una Pelicula");

            }

        }
    }
}
