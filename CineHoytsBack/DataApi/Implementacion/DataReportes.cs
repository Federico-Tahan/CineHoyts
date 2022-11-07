using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineHoytsBack.DataApi.Interfaces;
using CineHoytsBack.Datos.Implementacion;
using CineHoytsBack.Datos.Interfaces;
using CineHoytsBack.Datos.Interfaces;
using CineHoytsBack.Dominio;
using CineHoytsBack.Dominio.ClasesReportes;

namespace CineHoytsBack.DataApi.Implementacion
{
    public class DataReportes:IDataReportes
    {
        private IReportes lg;

        public DataReportes()
        {
            lg = new Reportes();
        }

        public List<TicketXVendedor> Cargar_Clientes_ConVentas()
        {
            return lg.Cargar_Clientes_ConVentas();
        }

        public List<GastoClientePromedio> ClientesPromGasto()
        {
            return lg.ClientesPromGasto();
        }

        public List<Espectadoresxpeli> Espxpel(int a)
        {
            return lg.Espxpel(a);
        }

        public List<GananciaXPel> gananciaxpeli()
        {
            return lg.gananciaxpeli();
        }

        public avg gasto()
        {
            return lg.gasto();
        }

        public List<MayMenGasto> maymenGasto()
        {
            return lg.maymengasto();
        }

        public List<recaudacionprod> rec()
        {
            return lg.rec();
        }

        public List<GastoClienteTot> TotalDeclientes(List<Parametro> p)
        {
            return lg.TotalDeclientes(p);
        }
    }
}
