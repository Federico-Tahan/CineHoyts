using Cine_Hoyts.Dominio;
using CineHoytsBack.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineHoytsBack.DataApi.Interfaces
{
    public interface IDataCRUDfactura
    {
        bool alta_Factura(Factura f);
        bool alta_Reserva(Factura f);
        List<Factura> Cargar_Facturas();
        List<Comprobante> Buscar_detalle(int c);
        List<Butaca> Buscar_Butacas(List<Parametro> pm);
        List<Butaca> Buscar_Butacas_ocupada(int sala, int funcion, int id_comprobante);

        bool Actualizar_pago(Factura f);
        List<Factura> Cargar_Facturas_concret();
        List<Factura> Cargar_Facturas_concret_filtered(string f);


        bool Baja_factura(Parametro p);
    }
}
