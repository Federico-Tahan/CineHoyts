using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineHoytsBack.Dominio.ClasesReportes
{
    public class GananciaXPel
    {
        public string titulo { get; set; }
        public int duracion { get; set; }
        public string descripcion { get; set; }
        public decimal ImporteGenerado { get; set; }
        public int Espectadores { get; set; }
    }
}
