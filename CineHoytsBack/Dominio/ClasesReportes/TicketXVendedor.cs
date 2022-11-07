using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineHoytsBack.Dominio.ClasesReportes
{
    public class TicketXVendedor
    {
        public int id_vendedor { get; set; }
        public string Nombreyapellido { get; set; }
        public long numerodedocumento { get; set; }
        public int Cantidad { get; set; }
    }
}
