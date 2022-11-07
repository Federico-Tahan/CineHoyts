using Cine_Hoyts.Dominio;
using CineHoytsBack.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Hoyts.Datos.Interfaces
{
    public interface ICRUD_FACTURA
    {
        bool alta_Factura(Factura f);
        bool alta_Reserva(Factura f);

        List<Factura> Cargar_Facturas();
        List<Butaca> Buscar_Butacas_ocupada(int sala, int funcion, int id_comprobante);
        List<Factura> Cargar_Facturas_concret();
        List<Factura> Cargar_Facturas_concret_filtered(string a);

        List<Comprobante> Buscar_detalle(int c);

        List<Butaca> Buscar_Butacas(List<Parametro> pm);

        bool Actualizar_pago(Factura f);

        bool Bajar_Factura(Parametro f);
    }
}
