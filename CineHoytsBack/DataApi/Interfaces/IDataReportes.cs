using CineHoytsBack.Dominio;
using CineHoytsBack.Dominio.ClasesReportes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineHoytsBack.DataApi.Interfaces
{
    public interface IDataReportes
    {
        List<GastoClientePromedio> ClientesPromGasto();
        avg gasto();
        List<TicketXVendedor> Cargar_Clientes_ConVentas();
        List<MayMenGasto> maymenGasto();
        List<GananciaXPel> gananciaxpeli();
        List<Espectadoresxpeli> Espxpel(int a);
        List<recaudacionprod> rec();
        List<GastoClienteTot> TotalDeclientes(List<Parametro> p);


    }
}
