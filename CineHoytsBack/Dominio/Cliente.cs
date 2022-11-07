using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Hoyts.Dominio
{
    public class Cliente
    {
        public int Id_Cliente { get; set; }
        public Persona per { get; set; }
        public string NombreCBO { get; set; }
        public double TotalGastado { get; set; }

    }
}
