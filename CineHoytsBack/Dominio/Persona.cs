using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Hoyts.Dominio
{
    public class Persona
    {
        public int Id_Persona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int Nro_Direccion { get; set; }
        public int id_barrio { get; set; }
        public long Nro_Documento { get; set; }
        public int Id_tipo_documento { get; set; }
        public string Fecha_Nac { get; set; }
        public int Sexo { get; set; }
        public string Tipo_doc { get; set; }
        public int id_localidad { get; set; }
        public int id_provincia { get; set; }

    }
}
