using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineHoytsBack.Dominio
{
    public class Butaca
    {
        public int id_butaca_sala { get; set; }
        public string Fila { get; set; }
        public int nro { get; set; }
        public int Estado { get; set; }


        public bool Buscar_bt(List<Butaca> b, Butaca but)
        {
            foreach (Butaca f in b)
            {
                if (f.id_butaca_sala == but.id_butaca_sala)
                {
                    return true;
                }
            }
            return false;

        }
    }
}
