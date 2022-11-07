using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineHoytsBack.Dominio.ClasesReportes
{
    public class GastoClientePromedio
    {
        public string nombre;
        public string barrio;
        public string direccion;
        public decimal importe;

        public GastoClientePromedio(string Nombre, string barrio, string Direccion, decimal Importe)
        {
            this.nombre = Nombre;
            this.barrio = barrio;
            this.direccion = Direccion;
            this.importe = Importe;
        }


    }
}
