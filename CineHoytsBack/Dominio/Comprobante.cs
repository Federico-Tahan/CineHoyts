using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Hoyts.Dominio
{
    public class Comprobante
    {
        public int Id_comprobante { get; set; }
        public Funcion Fun { get; set; }
        public int Id_promocion { get; set; }
        public int Promocion { get; set; }
        public int cantidad { get; set; }
        public double monto { get; set; }
        public double  Total { get; set; }
        public List<Ticket> TicketList { get; set; }
        public List<Ticket> TicketLista = new List<Ticket>();

        public bool buscar(int value)
        {
            for (int i = 0; i < TicketLista.Count; i++)
            {
                if (value == TicketLista[i].Id_butaca_sala)
                {
                    return true;
                }
            }
            return false;
        }
        public void remover(int index)
        {
            for (int i = 0; i < TicketLista.Count; i++)
            {
                if (index == TicketLista[i].Id_butaca_sala)
                {
                    TicketLista.Remove(TicketLista[i]);
                }
            }
        }


    }
}
