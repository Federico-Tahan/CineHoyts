using Cine_Hoyts.Datos.Implementacion;
using Cine_Hoyts.Datos.Interfaces;
using Cine_Hoyts.Dominio;
using CineHoytsBack.DataApi.Interfaces;
using CineHoytsBack.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineHoytsBack.DataApi.Implementacion
{
    public class DataCRUDfactura:IDataCRUDfactura
    {
        private ICRUD_FACTURA lg;

        public DataCRUDfactura()
        {
            lg = new CRUD_FACTURA();
        }

        public bool Actualizar_pago(Factura f)
        {
            return lg.Actualizar_pago(f);
        }
        public bool alta_Factura(Factura f)
        {
            return lg.alta_Factura(f);
        }
        public bool alta_Reserva(Factura f)
        {
            return lg.alta_Reserva(f);
        }

        public bool Baja_factura(Parametro p)
        {
            return lg.Bajar_Factura(p);
        }

        public List<Butaca> Buscar_Butacas(List<Parametro> pm)
        {
            return lg.Buscar_Butacas(pm);
        }

        public List<Butaca> Buscar_Butacas_ocupada(int sala, int funcion, int id_comprobante)
        {
            return lg.Buscar_Butacas_ocupada(sala,funcion,id_comprobante);
        }

        public List<Comprobante> Buscar_detalle(int c)
        {
            return lg.Buscar_detalle(c);
        }
        public List<Factura> Cargar_Facturas()
        {
            return lg.Cargar_Facturas();
        }

        public List<Factura> Cargar_Facturas_concret()
        {
            return lg.Cargar_Facturas_concret();
        }

        public List<Factura> Cargar_Facturas_concret_filtered(string f)
        {
            return lg.Cargar_Facturas_concret_filtered(f);
        }
    }
}
