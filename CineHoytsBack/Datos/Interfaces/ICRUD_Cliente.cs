using Cine_Hoyts.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineHoytsBack.Dominio;

namespace Cine_Hoyts.Datos.Interfaces
{
    public interface ICRUD_Cliente
    {
        bool alta(Cliente c);
        bool baja(Parametro c);
        bool Modificacion(Cliente c);
        List<Cliente> Cargar_Clientes();
        bool search_cliente(int c);
        List<Cliente> Cargar_Clientes_ConVentas();
        List<Cliente> Cargar_Clientes_ConVentas_rango(List<Parametro> pm);

        List<Cliente> Cargar_Clientes_ConVentas_rango_filtro(List<Parametro> pm);
        List<Cliente> Cargar_Clientes_ConVentas_Name(Parametro pm);




    }
}
