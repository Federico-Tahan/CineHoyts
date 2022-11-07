using Cine_Hoyts.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Hoyts.Datos.Interfaces
{
    public interface ILogIn
    {
        bool Logeado(Vendedor v);

        Vendedor GetDatos(Vendedor v);
    }
}
