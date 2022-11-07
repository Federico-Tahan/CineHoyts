using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Hoyts.Dominio
{
    internal class Reserva
    {
        public int Id_reserva { get; set; }
        public DateTime Fecha { get; set; }
        Factura Factura = new Factura();
    }
}
