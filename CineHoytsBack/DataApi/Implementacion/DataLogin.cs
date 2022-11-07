using Cine_Hoyts.Datos.Implementacion;
using Cine_Hoyts.Datos.Interfaces;
using Cine_Hoyts.Dominio;
using CineHoytsBack.DataApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineHoytsBack.DataApi.Implementacion
{
    public class DataLogin:IDataLogin
    {
        private ILogIn lg;

        public DataLogin()
        {
            lg = new Login();
        }
        public Vendedor GetDatos(Vendedor v)
        {
            return lg.GetDatos(v);
        }

        public bool Logeado(Vendedor v)
        {
            return lg.Logeado(v);
        }
    }
}
