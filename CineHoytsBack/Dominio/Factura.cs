using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Hoyts.Dominio
{
    public class Factura
    {

        public int id_Factura { get; set; }
        public string fecha_Reserva { get; set; }
        public int id_vendedor { get; set; }
        public Vendedor vendedor { get; set; }

        public int id_cliente { get; set; }
        
        public Cliente cliente { get; set; }
        public int id_Tipo_Compra { get; set; }
        public string tipoCompra { get; set; }
        public int id_Forma_Pago { get; set; }
        public string formaPago { get; set; }

        public string fecha_Pago { get; set; } = DateTime.MinValue.ToShortDateString();
        public int estado { get; set; }
        public List<Comprobante> Lcomprobantes { get; set; }
        public List<Comprobante> listComprobobante = new List<Comprobante>();



        public void remover(int index)
        {
            listComprobobante.Remove(listComprobobante[index]);
        }

        public bool buscar(int value)
        {
            for (int i = 0; i < listComprobobante.Count; i++)
            {
                if (value == listComprobobante[i].Fun.id_funcion)
                {
                    return false;
                }
            }
            return true;
        }

        public double calcular_total()
        {
            double Total = 0;
            foreach (Comprobante item in listComprobobante)
            {

                if (item.Id_promocion == 1)
                {
                    item.Promocion = 50;
                }
                else if (item.Id_promocion == 2)
                {
                    item.Promocion = 80;

                }
                else if (item.Id_promocion == 3)
                {
                    item.Promocion = 25;
                }
                else if (item.Id_promocion == 4)
                {
                    item.Promocion = 40;

                }
                else if (item.Id_promocion == 5)
                {
                    item.Promocion = 30;
                }
                else
                {
                    item.Promocion = 35;

                }
                Total += item.monto * item.cantidad - (((item.monto * item.cantidad) * item.Promocion) / 100);
            }

            return Total;
        }

        public double calcular_total_con()
        {
            if (Lcomprobantes is null)
            {
                return 0;
            }
            else
            {
                double Total = 0;
                foreach (Comprobante item in Lcomprobantes)
                {

                    if (item.Id_promocion == 1)
                    {
                        item.Promocion = 50;
                    }
                    else if (item.Id_promocion == 2)
                    {
                        item.Promocion = 80;

                    }
                    else if (item.Id_promocion == 3)
                    {
                        item.Promocion = 25;
                    }
                    else if (item.Id_promocion == 4)
                    {
                        item.Promocion = 40;

                    }
                    else if (item.Id_promocion == 5)
                    {
                        item.Promocion = 30;
                    }
                    else
                    {
                        item.Promocion = 35;

                    }
                    Total += item.monto * item.cantidad - (((item.monto * item.cantidad) * item.Promocion) / 100);
                }

                return Total;
            }
              

            
        }
    }
}
