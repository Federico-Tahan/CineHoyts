using CineHoytsBack.Dominio;
using CineHoytsBack.Dominio.ClasesReportes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineHoytsBack.Datos.Interfaces
{
    public interface IReportes
    {

        List<GastoClientePromedio> ClientesPromGasto();
        avg gasto();
       List<TicketXVendedor> Cargar_Clientes_ConVentas();
        List<MayMenGasto> maymengasto();
        List<GananciaXPel> gananciaxpeli();
        List<Espectadoresxpeli> Espxpel(int a);
        List<recaudacionprod> rec();
        List<GastoClienteTot> TotalDeclientes(List<Parametro> p);






    }
}
