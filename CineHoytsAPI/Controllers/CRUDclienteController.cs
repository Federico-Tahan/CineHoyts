using Cine_Hoyts.Dominio;
using CineHoytsBack.DataApi.Implementacion;
using CineHoytsBack.DataApi.Interfaces;
using CineHoytsBack.Dominio;
using Microsoft.AspNetCore.Mvc;

namespace CineHoytsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CRUDclienteController : Controller
    {
        private IDataCRUDcliente back;
        public CRUDclienteController()
        {
            back = new DataCRUDcliente();
        }

        [HttpPost("PostAltaCliente")]
        public IActionResult PostAlta(Cliente c)
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

        [HttpPost("PutBajaCliente")]
        public IActionResult PutBaja(Parametro c)
        {
            if (c is not null)
            {
                try
                {
                    return Ok(back.baja(c));

                }
                catch (Exception)
                {
                    return BadRequest("Error del servidor, intentelo de nuevo más tarde");

                }
            }
            else
            {
                return BadRequest("Debe cargar un parametro");


            }

        }

        [HttpPost("PutModificarCliente")]
        public IActionResult PutModificar(Cliente c)
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

        [HttpGet("GetCliente")]
        public IActionResult GetCliente()
        {
            try
            {
                return Ok(back.Cargar_Clientes());

            }
            catch (Exception)
            {
                return BadRequest("Error del servidor, intentelo de nuevo más tarde");
            }
        }

        [HttpGet("GetExisteCliente")]
        public IActionResult GetExisteCliente(int c)
        {
            try
            {
                return Ok(back.search_cliente(c));

            }
            catch (Exception)
            {
                return BadRequest("Error del servidor, intentelo de nuevo más tarde");
            }
        }

        [HttpGet("GetClienteConVenta")]
        public IActionResult Cargar_Clientes_ConVentas()
        {
            try
            {
                return Ok(back.Cargar_Clientes_ConVentas());

            }
            catch
            {
                return BadRequest("Error del servidor, intentelo de nuevo más tarde");
            }

        }
        [HttpPost("GetClienteConVentaRango")]

        public IActionResult Cargar_Clientes_ConVentas_filter(List<Parametro> pm)
        {
            if (pm is not null)
            {
                try
                {
                    return Ok(back.Cargar_Clientes_ConVentas_rango(pm));

                }
                catch
                {
                    return BadRequest("Error del servidor, intentelo de nuevo más tarde");
                }
            }
            else
            {
                return BadRequest("La lista de parametros está vacia");

            }


        }

        [HttpPost("GetClienteConVentaRango_filter")]

        public IActionResult Cargar_Clientes_ConVentas_filter_name(List<Parametro> pm)
        {
            if (pm is not null)
            {
                try
                {
                    return Ok(back.Cargar_Clientes_ConVentas_rango_nombre(pm));

                }
                catch
                {
                    return BadRequest("Error del servidor, intentelo de nuevo más tarde");
                }
            }
            else
            {
                return BadRequest("La lista de parametros está vacia");

            }


        }

        [HttpPost("GetClienteConFilter")]

        public IActionResult Cargar_ClientesName(Parametro pm)
        {


            if (pm is not null)
            {
                try
                {
                    return Ok(back.Cargar_Clientes_ConVentas_Name(pm));

                }
                catch
                {
                    return BadRequest("Error del servidor, intentelo de nuevo más tarde");
                }
            }
            else
            {
                return BadRequest("La lista de parametros está vacia");

            }


        }


    }
}
