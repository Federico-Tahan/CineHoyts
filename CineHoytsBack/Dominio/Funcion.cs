using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Hoyts.Dominio
{
    public class Funcion
    {
        public int id_funcion { get; set; }
        public string Fecha { get; set; }
        public int Id_idioma { get; set; }
        public string Idioma { get; set; }
        public string Sala { get; set; }
        public int Id_pelicula { get; set; }
        public string Pelicula { get; set; }
        public int Id_horario { get; set; }
        public string Hora { get; set; }
        public int Id_sala { get; set; }
        public int Id_TipoSala { get; set; }

        public double monto { get; set; }
    }
}
