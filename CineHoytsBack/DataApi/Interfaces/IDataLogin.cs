using Cine_Hoyts.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineHoytsBack.DataApi.Interfaces
{
    public interface IDataLogin
    {
        bool Logeado(Vendedor v);

        Vendedor GetDatos(Vendedor v);
    }
}
