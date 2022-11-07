using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineHoytsBack.Dominio.ClasesReportes
{
    public class recaudacionprod
    {
        public int id_producto { get; set; }
        public string nombre { get; set; }
        public decimal Total { get; set; }
        public string TIPO { get; set; }
    }
}
