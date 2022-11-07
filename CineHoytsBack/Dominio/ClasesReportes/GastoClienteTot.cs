using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineHoytsBack.Dominio.ClasesReportes
{
    public class GastoClienteTot
    {
        public int Codigo { get; set; }
        public string Cliente { get; set; }
        public decimal CantidadGastado { get; set; }
        public int Entradascompradas { get; set; }
    }
}
