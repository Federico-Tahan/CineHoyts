using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Hoyts.Dominio
{
    public class Vendedor
    {
        public int Id_Vendedor { get; set; }
        public Persona per { get; set; }
        public string nombreCBO { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public int admin { get; set; }
    }
}
