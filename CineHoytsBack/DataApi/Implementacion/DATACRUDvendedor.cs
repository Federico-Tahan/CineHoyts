using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cine_Hoyts.Dominio;
using CineHoytsBack.DataApi.Interfaces;
using CineHoytsBack.Datos.Interfaces;
using CineHoytsBack.Datos.Implementacion;

namespace CineHoytsBack.DataApi.Implementacion
{
    public class DATACRUDvendedor : IDATACRUDvendedor
    {
        private ICRUD_Vendedor lg;

        public DATACRUDvendedor()
        {
            lg = new CRUD_Vendedor();
        }
        public bool alta(Vendedor c)
        {
            return lg.alta(c);
        }

        public bool baja(int c)
        {
            return lg.baja(c);
        }

        public List<Vendedor> Cargar_Vendedores()
        {
            return lg.Cargar_Vendedores();
        }

        public bool Modificacion(Vendedor c)
        {
            return lg.Modificacion(c);
        }

        public bool search_Vendedor(int c)
        {
            return lg.search_Vendedor(c);
        }
    }
}
