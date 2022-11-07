using Cine_Hoyts.Datos.Implementacion;
using Cine_Hoyts.Dominio;
using CineHoytsBack.DataApi.Implementacion;
using CineHoytsBack.DataApi.Interfaces;
using CineHoytsBack.Dominio;
using Microsoft.AspNetCore.Mvc;

namespace CineHoytsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CRUDfacturaController : Controller
    {
        private IDataCRUDfactura back;

        public CRUDfacturaController()
        {
            back = new DataCRUDfactura();
        }

        [HttpGet("GetFacturas")]
        public IActionResult GetFacturas()
        {
            try
            {
                return Ok(back.Cargar_Facturas());

            }
            catch (Exception)
            {
                return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
            }
        }
        [HttpGet("GetFacturaConcret")]
        public IActionResult GetFacturaConcrect()
        {
            try
            {
                return Ok(back.Cargar_Facturas_concret());

            }
            catch
            {
                return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
            }
        }

        [HttpPost("PostFacturas")]
        public IActionResult PostFactura(Factura f)
        {
            if (f is not null)
            {
                try
                {
                    return Ok(back.alta_Factura(f));

                }
                catch (Exception)
                {
                    return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
                }
            }
            else
            {
                return BadRequest("Debe cargar una factura");

            }

        }

        [HttpPost("PostReserva")]
        public IActionResult PostReserva(Factura f)
        {
            if (f is not null)
            {
                try
                {
                    return Ok(back.alta_Reserva(f));

                }
                catch (Exception)
                {
                    return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");

                }
            }
            else
            {
                return BadRequest("Debe cargar una factura");
            }

        }

        [HttpGet("GetDetalle")]
        public IActionResult GetDetalle(int f)
        {
            try
            {
                return Ok(back.Buscar_detalle(f));

            }
            catch (Exception)
            {
                return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");

            }
        }

        [HttpGet("GetFacturaConClientefilter")]
        public IActionResult Getfiltercliente(string f)
        {
            try
            {
                return Ok(back.Cargar_Facturas_concret_filtered(f));

            }
            catch (Exception)
            {
                return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");

            }
        }

        [HttpPost("GetButacas")]
        public IActionResult GetButacas(List<Parametro> pm)
        {
            if (pm is not null)
            {
                try
                {
                    return Ok(back.Buscar_Butacas(pm));

                }
                catch (Exception)
                {
                    return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");

                }
            }
            else
            {
                return BadRequest("Debe cargar un parametro");
            }

        }

        [HttpGet("GetButacasOcupa")]
        public IActionResult GetButacasOcupadas(int sala, int funcion,int id_comprobante)
        {
            try
            {
                return Ok(back.Buscar_Butacas_ocupada(sala, funcion, id_comprobante));

            }
            catch (Exception)
            {
                return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");

            }
        }

        [HttpPost("PutPago")]
        public IActionResult PutPago(Factura f)
        {
                try
                {
                    return Ok(back.Actualizar_pago(f));

                }
                catch (Exception)
                {
                    return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
                }
        }

        [HttpPost("BajaFactura")]
        public IActionResult BajaFactura(Parametro f)
        {
            try
            {
                return Ok(back.Baja_factura(f));

            }
            catch (Exception)
            {
                return BadRequest("Error interno del Servidor, Intentelo nuevamente más Tarde");
            }
        }

    }
}
