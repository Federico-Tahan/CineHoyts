using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineHoytsBack.Dominio.ClasesReportes
{
    public class Espectadoresxpeli
    {
        public int id_pelicula { get; set; }
        public string titulo { get; set; }
        public int duracion { get; set; }
        public int cantidad_entradas { get; set; }
    }
}
