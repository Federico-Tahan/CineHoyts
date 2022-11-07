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
    public class DataCRUDcliente:IDataCRUDcliente
    {
        private ICRUD_Cliente lg;

        public DataCRUDcliente()
        {
            lg = new CRUD_CLIENTE();
        }
        public bool alta(Cliente c)
        {
            return lg.alta(c);
        }

        public bool baja(Parametro c)
        {
            return lg.baja(c);
        }

        public List<Cliente> Cargar_Clientes()
        {
            return lg.Cargar_Clientes();
        }

        public List<Cliente> Cargar_Clientes_ConVentas()
        {
            return lg.Cargar_Clientes_ConVentas();
        }

        public List<Cliente> Cargar_Clientes_ConVentas_Name(Parametro pm)
        {
            return lg.Cargar_Clientes_ConVentas_Name(pm);
        }

        public List<Cliente> Cargar_Clientes_ConVentas_rango(List<Parametro> pm)
        {
            return lg.Cargar_Clientes_ConVentas_rango(pm);
        }

        public List<Cliente> Cargar_Clientes_ConVentas_rango_nombre(List<Parametro> pm)
        {
            return lg.Cargar_Clientes_ConVentas_rango_filtro(pm);
        }

        public bool Modificacion(Cliente c)
        {
            return lg.Modificacion(c);
        }

        public bool search_cliente(int c)
        {
            return lg.search_cliente(c);
        }
    }
}
