using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cine_Hoyts.Datos;
using CineHoytsBack.Datos.Interfaces;
using CineHoytsBack.Dominio;
using CineHoytsBack.Dominio.ClasesReportes;

namespace CineHoytsBack.Datos.Implementacion
{
    public class Reportes : IReportes
    {
        public List<GastoClientePromedio> ClientesPromGasto()
        {
            List<GastoClientePromedio> lCliente = new List<GastoClientePromedio>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_GastoClientes");
            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                GastoClientePromedio c = new GastoClientePromedio(HelperDB.ObtenerInstancia().Dr.GetString(0),
                    HelperDB.ObtenerInstancia().Dr.GetString(1), HelperDB.ObtenerInstancia().Dr.GetString(2), HelperDB.ObtenerInstancia().Dr.GetDecimal(3));

                lCliente.Add(c);
            }
            HelperDB.ObtenerInstancia().close();
            return lCliente;
        }

        public avg gasto()
        {
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_GetAvg");
            avg c = new avg();
            if(HelperDB.ObtenerInstancia().Dr.Read())
            {
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.GastoPromedio = HelperDB.ObtenerInstancia().Dr.GetDecimal(0);
                }
            }
            HelperDB.ObtenerInstancia().close();
            return c;
        }


        public List<TicketXVendedor> Cargar_Clientes_ConVentas()
        {
            List<TicketXVendedor> lCliente = new List<TicketXVendedor>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_TICKETSxVENDEDOR");
            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                TicketXVendedor c = new TicketXVendedor();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.id_vendedor = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    c.Nombreyapellido = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    c.numerodedocumento = HelperDB.ObtenerInstancia().Dr.GetInt64(2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    c.Cantidad = HelperDB.ObtenerInstancia().Dr.GetInt32(3);
                }
                lCliente.Add(c);
            }
            HelperDB.ObtenerInstancia().close();
            return lCliente;
        }

        public List<MayMenGasto> maymengasto()
        {
            List<MayMenGasto> lCliente = new List<MayMenGasto>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_MAYOR_MENOR_GASTO");
            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                MayMenGasto c = new MayMenGasto();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.name = HelperDB.ObtenerInstancia().Dr.GetString(0);
                }

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    c.barrio = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    c.direc = HelperDB.ObtenerInstancia().Dr.GetString(2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    c.totalgastado = HelperDB.ObtenerInstancia().Dr.GetDecimal(3);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                {
                    c.Top_Gasto = HelperDB.ObtenerInstancia().Dr.GetString(4);
                }
                lCliente.Add(c);
            }
            HelperDB.ObtenerInstancia().close();
            return lCliente;
        }

        public List<GananciaXPel> gananciaxpeli()
        {
            List<GananciaXPel> lCliente = new List<GananciaXPel>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_GananciasXPelicula");
            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                GananciaXPel c = new GananciaXPel();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.titulo = HelperDB.ObtenerInstancia().Dr.GetString(0);
                }

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    c.duracion = HelperDB.ObtenerInstancia().Dr.GetInt32(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    c.descripcion = HelperDB.ObtenerInstancia().Dr.GetString(2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    c.ImporteGenerado = HelperDB.ObtenerInstancia().Dr.GetDecimal(3);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                {
                    c.Espectadores = HelperDB.ObtenerInstancia().Dr.GetInt32(4);
                }
                lCliente.Add(c);
            }
            HelperDB.ObtenerInstancia().close();
            return lCliente;
        }

        public List<Espectadoresxpeli> Espxpel(int p)
        {
            List<Espectadoresxpeli> lCliente = new List<Espectadoresxpeli>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@MINIMO",p);

            HelperDB.ObtenerInstancia().LeerDB("SP_CANTIDAD_ENTRADAS_MIN");
            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Espectadoresxpeli c = new Espectadoresxpeli();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.id_pelicula = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    c.titulo = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    c.duracion = HelperDB.ObtenerInstancia().Dr.GetInt32(2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    c.cantidad_entradas = HelperDB.ObtenerInstancia().Dr.GetInt32(3);
                }
                lCliente.Add(c);
            }
            HelperDB.ObtenerInstancia().close();
            return lCliente;
        }

        public List<recaudacionprod> rec()
        {
            List<recaudacionprod> lCliente = new List<recaudacionprod>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_RecaudacionPorFechas");
            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                recaudacionprod c = new recaudacionprod();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.id_producto = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    c.nombre = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    c.Total = HelperDB.ObtenerInstancia().Dr.GetDecimal(2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    c.TIPO = HelperDB.ObtenerInstancia().Dr.GetString(3);
                }
                lCliente.Add(c);
            }
            HelperDB.ObtenerInstancia().close();
            return lCliente;
        }

        public List<GastoClienteTot> TotalDeclientes(List<Parametro> p)
        {
            List<GastoClienteTot> lCliente = new List<GastoClienteTot>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@fecha1", Convert.ToDateTime(p[0].Valor.ToString()));
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@fecha2", Convert.ToDateTime(p[1].Valor.ToString()));
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@apellido", p[2].Valor.ToString()); ;


            HelperDB.ObtenerInstancia().LeerDB("SP_GastoTotalDeClientes");
            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                GastoClienteTot c = new GastoClienteTot();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.Codigo = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    c.Cliente = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    c.CantidadGastado = HelperDB.ObtenerInstancia().Dr.GetDecimal(2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    c.Entradascompradas = HelperDB.ObtenerInstancia().Dr.GetInt32(3);
                }
                lCliente.Add(c);
            }
            HelperDB.ObtenerInstancia().close();
            return lCliente;
        }
    }
}
