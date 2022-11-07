using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Hoyts.Dominio
{
    public class Ticket
    {
        public int Id_ticket { get; set; }
        public int Id_butaca_sala { get; set; }
        public int Id_Tipo_Publico { get; set; }
        public string TipoPublico { get; set; }
        public string Cod_Butaca { get; set; }

    }
}
