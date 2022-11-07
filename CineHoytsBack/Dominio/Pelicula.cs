using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Hoyts.Dominio
{
    public class Pelicula
    {
        public int id_pel { get; set; }
        public string Titulo { get; set; }
        public int Duracion { get; set; }
        public string productor { get; set; }
        public int Edad { get; set; }
        public int Espectadores { get; set; }
        public string Descripcion { get; set; }
        public int id_edad { get; set; }
        public int id_prod { get; set; }
        public byte[] Imagen { get; set; }

    }
}
