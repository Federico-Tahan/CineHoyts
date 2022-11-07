using Cine_Hoyts.Datos.Interfaces;
using Cine_Hoyts.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineHoytsBack.Dominio;

namespace Cine_Hoyts.Datos.Implementacion
{
    public class CRUD_FACTURA : ICRUD_FACTURA
    {
        public bool alta_Factura(Factura f)
        {
            bool bandera = false;
            SqlConnection conn = HelperDB.ObtenerInstancia().conexion();
            SqlTransaction tr = null;
            try
            {
                HelperDB.ObtenerInstancia().open();
                tr = conn.BeginTransaction();
                HelperDB.ObtenerInstancia().Command.Transaction = tr;
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@fecha_reserva", Convert.ToDateTime(f.fecha_Reserva));
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_vendedor",f.id_vendedor);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_cliente", f.id_cliente);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@fecha_pago", Convert.ToDateTime(f.fecha_Pago));
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_tipo_compra", f.id_Tipo_Compra);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_forma_pago", f.id_Forma_Pago);

                SqlParameter pOut = new SqlParameter();
                pOut.ParameterName = "@id";
                pOut.DbType = DbType.Int32;
                pOut.Direction = ParameterDirection.Output;
                HelperDB.ObtenerInstancia().Command.Parameters.Add(pOut);
                HelperDB.ObtenerInstancia().Command.CommandText = "SP_INSERTAR_FACTURA_PAGADA";
                HelperDB.ObtenerInstancia().Command.ExecuteNonQuery();
                f.id_Factura = (int)pOut.Value;

                HelperDB.ObtenerInstancia().Command.Parameters.Clear();

                /*RETORNAR ID_fACUTRA*/
                for (int i = 0; i < f.Lcomprobantes.Count; i++)
                {
                    HelperDB.ObtenerInstancia().Command.Transaction = tr;

                    HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_funcion", f.Lcomprobantes[i].Fun.id_funcion);
                    HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@cantidad", f.Lcomprobantes[i].cantidad);
                    HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_factura", f.id_Factura);
                    HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@monto", f.Lcomprobantes[i].monto);
                    HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_promocion", f.Lcomprobantes[i].Id_promocion);
                    HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@fecha_fun", Convert.ToDateTime(f.Lcomprobantes[i].Fun.Fecha));



                    SqlParameter pOut2 = new SqlParameter();
                    pOut2.ParameterName = "@id";
                    pOut2.DbType = DbType.Int32;
                    pOut2.Direction = ParameterDirection.Output;
                    HelperDB.ObtenerInstancia().Command.Parameters.Add(pOut2);
                    HelperDB.ObtenerInstancia().Command.CommandText = "SP_INSERTAR_COMPROBANTE";
                    HelperDB.ObtenerInstancia().Command.ExecuteNonQuery();
                    f.Lcomprobantes[i].Id_comprobante = (int)pOut2.Value;

                    HelperDB.ObtenerInstancia().Command.Parameters.Clear();

                    for (int x = 0; x < f.Lcomprobantes[i].TicketList.Count; x++)
                    {
                        HelperDB.ObtenerInstancia().Command.Transaction = tr;

                        HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_comprobante", f.Lcomprobantes[i].Id_comprobante);
                        HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_butaca_sala", f.Lcomprobantes[i].TicketList[x].Id_butaca_sala);
                        HelperDB.ObtenerInstancia().Command.CommandText = "INSERTAR_TICKET";
                        HelperDB.ObtenerInstancia().Command.ExecuteNonQuery();
                        HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                    }
                }
                tr.Commit();
                bandera = true;
            }
            catch (Exception)
            {
                tr.Rollback();
                bandera = false;
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    HelperDB.ObtenerInstancia().close();
                }
            }
            return bandera;
        }

        public bool alta_Reserva(Factura f)
        {
            bool bandera = false;
            SqlConnection conn = HelperDB.ObtenerInstancia().conexion();
            SqlTransaction tr = null;
            try
            {
                HelperDB.ObtenerInstancia().open();
                tr = conn.BeginTransaction();
                HelperDB.ObtenerInstancia().Command.Transaction = tr;
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@fecha_reserva", Convert.ToDateTime(f.fecha_Reserva));
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_vendedor", f.id_vendedor);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_cliente", f.id_cliente);

                SqlParameter pOut = new SqlParameter();
                pOut.ParameterName = "@id";
                pOut.DbType = DbType.Int32;
                pOut.Direction = ParameterDirection.Output;
                HelperDB.ObtenerInstancia().Command.Parameters.Add(pOut);
                HelperDB.ObtenerInstancia().Command.CommandText = "SP_INSERTAR_FACTURA_POSPUESTA";
                HelperDB.ObtenerInstancia().Command.ExecuteNonQuery();
                f.id_Factura = (int)pOut.Value;

                HelperDB.ObtenerInstancia().Command.Parameters.Clear();

                /*RETORNAR ID_fACUTRA*/
                for (int i = 0; i < f.Lcomprobantes.Count; i++)
                {
                    HelperDB.ObtenerInstancia().Command.Transaction = tr;

                    HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_funcion", f.Lcomprobantes[i].Fun.id_funcion);
                    HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@cantidad", f.Lcomprobantes[i].cantidad);
                    HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_factura", f.id_Factura);
                    HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@monto", f.Lcomprobantes[i].monto);
                    HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_promocion", f.Lcomprobantes[i].Id_promocion);
                    HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@fecha_fun", Convert.ToDateTime(f.Lcomprobantes[i].Fun.Fecha));



                    SqlParameter pOut2 = new SqlParameter();
                    pOut2.ParameterName = "@id";
                    pOut2.DbType = DbType.Int32;
                    pOut2.Direction = ParameterDirection.Output;
                    HelperDB.ObtenerInstancia().Command.Parameters.Add(pOut2);
                    HelperDB.ObtenerInstancia().Command.CommandText = "SP_INSERTAR_COMPROBANTE";
                    HelperDB.ObtenerInstancia().Command.ExecuteNonQuery();
                    f.Lcomprobantes[i].Id_comprobante = (int)pOut2.Value;

                    HelperDB.ObtenerInstancia().Command.Parameters.Clear();

                    for (int x = 0; x < f.Lcomprobantes[i].TicketList.Count; x++)
                    {
                        HelperDB.ObtenerInstancia().Command.Transaction = tr;

                        HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_comprobante", f.Lcomprobantes[i].Id_comprobante);
                        HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_butaca_sala", f.Lcomprobantes[i].TicketList[x].Id_butaca_sala);
                        HelperDB.ObtenerInstancia().Command.CommandText = "INSERTAR_TICKET";
                        HelperDB.ObtenerInstancia().Command.ExecuteNonQuery();
                        HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                    }
                }
                tr.Commit();
                bandera = true;
            }
            catch (Exception)
            {
                tr.Rollback();
                bandera = false;
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    HelperDB.ObtenerInstancia().close();
                }
            }
            return bandera;
        }

        public List<Factura> Cargar_Facturas()
        {
            List<Factura> LFactura = new List<Factura>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_FACTURAS");
            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Factura c = new Factura();
                Vendedor v = new Vendedor();
                Cliente cli = new Cliente();
                Persona pc = new Persona();
                Persona pv = new Persona();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.id_Factura = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    v.Id_Vendedor = HelperDB.ObtenerInstancia().Dr.GetInt32(1);
                    c.id_vendedor = HelperDB.ObtenerInstancia().Dr.GetInt32(1);

                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    pv.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    pv.Apellido = HelperDB.ObtenerInstancia().Dr.GetString(3);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                {
                    cli.Id_Cliente = HelperDB.ObtenerInstancia().Dr.GetInt32(4);
                    c.id_cliente = HelperDB.ObtenerInstancia().Dr.GetInt32(4);

                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(5))
                {
                    pc.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(5);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(6))
                {
                    pc.Apellido = HelperDB.ObtenerInstancia().Dr.GetString(6);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(7))
                {
                    c.fecha_Pago = HelperDB.ObtenerInstancia().Dr.GetDateTime(7).ToShortDateString();
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(8))
                {
                    c.fecha_Reserva= HelperDB.ObtenerInstancia().Dr.GetDateTime(8).ToShortDateString();
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(9))
                {
                    c.id_Tipo_Compra = HelperDB.ObtenerInstancia().Dr.GetInt32(9);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(10))
                {
                    c.tipoCompra = HelperDB.ObtenerInstancia().Dr.GetString(10);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(11))
                {
                    c.id_Forma_Pago = HelperDB.ObtenerInstancia().Dr.GetInt32(11);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(12))
                {
                    c.formaPago = HelperDB.ObtenerInstancia().Dr.GetString(12);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(13))
                {
                    c.estado = HelperDB.ObtenerInstancia().Dr.GetInt32(13);
                }

                cli.per = pc;
                v.per = pv;
                c.cliente = cli;
                c.vendedor = v;
                

                LFactura.Add(c);
            }
            HelperDB.ObtenerInstancia().close();
            return LFactura;
        }

        public List<Factura> Cargar_Facturas_concret()
        {
            List<Factura> LFactura = new List<Factura>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_FACTURAS_cocretadas");
            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Factura c = new Factura();
                Vendedor v = new Vendedor();
                Cliente cli = new Cliente();
                Persona pc = new Persona();
                Persona pv = new Persona();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.id_Factura = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    v.Id_Vendedor = HelperDB.ObtenerInstancia().Dr.GetInt32(1);
                    c.id_vendedor = HelperDB.ObtenerInstancia().Dr.GetInt32(1);

                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    pv.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    pv.Apellido = HelperDB.ObtenerInstancia().Dr.GetString(3);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                {
                    cli.Id_Cliente = HelperDB.ObtenerInstancia().Dr.GetInt32(4);
                    c.id_cliente = HelperDB.ObtenerInstancia().Dr.GetInt32(1);

                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(5))
                {
                    pc.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(5);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(6))
                {
                    pc.Apellido = HelperDB.ObtenerInstancia().Dr.GetString(6);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(7))
                {
                    c.fecha_Pago = HelperDB.ObtenerInstancia().Dr.GetDateTime(7).ToShortDateString();
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(8))
                {
                    c.fecha_Reserva = HelperDB.ObtenerInstancia().Dr.GetDateTime(8).ToShortDateString();
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(9))
                {
                    c.id_Tipo_Compra = HelperDB.ObtenerInstancia().Dr.GetInt32(9);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(10))
                {
                    c.tipoCompra = HelperDB.ObtenerInstancia().Dr.GetString(10);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(11))
                {
                    c.id_Forma_Pago = HelperDB.ObtenerInstancia().Dr.GetInt32(11);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(12))
                {
                    c.formaPago = HelperDB.ObtenerInstancia().Dr.GetString(12);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(13))
                {
                    c.estado = HelperDB.ObtenerInstancia().Dr.GetInt32(13);
                }

                cli.per = pc;
                v.per = pv;
                c.cliente = cli;
                c.vendedor = v;

                LFactura.Add(c);
            }
            HelperDB.ObtenerInstancia().close();
            return LFactura;
        }

        public List<Comprobante> Buscar_detalle(int c)
        {
            List<Comprobante> comprobantes = new List<Comprobante>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_factura", c);
            HelperDB.ObtenerInstancia().LeerDB("SP_CARGAR_Comprobante");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            while (HelperDB.ObtenerInstancia().Dr.Read()
)
            {
                Comprobante f = new Comprobante();
                Funcion fun = new Funcion();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    f.Id_comprobante = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    fun.id_funcion = HelperDB.ObtenerInstancia().Dr.GetInt32(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    fun.Id_idioma = HelperDB.ObtenerInstancia().Dr.GetInt32(2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    fun.Idioma = HelperDB.ObtenerInstancia().Dr.GetString(3);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                {
                    f.Id_promocion = HelperDB.ObtenerInstancia().Dr.GetInt32(4);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(8))
                {
                    fun.Id_pelicula = HelperDB.ObtenerInstancia().Dr.GetInt32(8);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(9))
                {
                    fun.Pelicula = HelperDB.ObtenerInstancia().Dr.GetString(9);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(10))
                {
                    fun.Id_sala = HelperDB.ObtenerInstancia().Dr.GetInt32(10);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(11))
                {
                    fun.Sala = Convert.ToString(HelperDB.ObtenerInstancia().Dr.GetInt32(11)) + HelperDB.ObtenerInstancia().Dr.GetString(12);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(13))
                {
                    fun.Id_horario = HelperDB.ObtenerInstancia().Dr.GetInt32(13);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(14))
                {
                    fun.Hora = HelperDB.ObtenerInstancia().Dr.GetString(14);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(15))
                {
                    f.monto = Convert.ToDouble(HelperDB.ObtenerInstancia().Dr.GetValue(15));
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(16))
                {
                    fun.Fecha = HelperDB.ObtenerInstancia().Dr.GetDateTime(16).ToShortDateString();
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(17))
                {
                    f.cantidad = HelperDB.ObtenerInstancia().Dr.GetInt32(17);
                }
                f.Fun = fun;
                comprobantes.Add(f);
            }
            HelperDB.ObtenerInstancia().close();
            return comprobantes;

        }

        public List<Butaca> Buscar_Butacas(List<Parametro> pm)
        {
            List<Butaca> a = new List<Butaca>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_sala", Convert.ToInt32(pm[0].Valor.ToString()));
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_funcion", Convert.ToInt32(pm[1].Valor.ToString()));
            HelperDB.ObtenerInstancia().LeerDB("SP_CARGAR_BUTACAS_Prueba");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Butaca b = new Butaca();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    b.id_butaca_sala = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    b.Fila = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    b.nro = HelperDB.ObtenerInstancia().Dr.GetInt32(2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    b.Estado = HelperDB.ObtenerInstancia().Dr.GetInt32(3);
                }

                a.Add(b);
            }
            HelperDB.ObtenerInstancia().close();
            return a;
        }

        public bool Actualizar_pago(Factura f)
        {
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_factura",f.id_Factura);
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_tipo_compra", f.id_Tipo_Compra);
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_forma_pago", f.id_Forma_Pago);
            HelperDB.ObtenerInstancia().updatear_db("SP_ACTUALIZAR_PAGO");
            return true;
        }

        public List<Butaca> Buscar_Butacas_ocupada(int sala, int funcion,int id_comprobante) 
        {
            List<Butaca> a = new List<Butaca>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_funcion", funcion);
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_sala", sala);
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_comprobante", id_comprobante);
            HelperDB.ObtenerInstancia().LeerDB("SP_CARGAR_BUTACAS_Ocupada");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Butaca b = new Butaca();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    b.id_butaca_sala = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    b.Fila = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    b.nro = HelperDB.ObtenerInstancia().Dr.GetInt32(2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    b.Estado = HelperDB.ObtenerInstancia().Dr.GetInt32(3);
                }

                a.Add(b);
            }
            HelperDB.ObtenerInstancia().close();
            return a;
        }

        public bool Bajar_Factura(Parametro f)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_factura", Convert.ToInt32(f.Valor.ToString()));
                HelperDB.ObtenerInstancia().updatear_db("SP_BAJAR_FACTURA");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Factura> Cargar_Facturas_concret_filtered(string p)
        {
            List<Factura> LFactura = new List<Factura>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nombre", p);
            HelperDB.ObtenerInstancia().LeerDB("SP_FACTURAS_cocretadas_filtered");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Factura c = new Factura();
                Vendedor v = new Vendedor();
                Cliente cli = new Cliente();
                Persona pc = new Persona();
                Persona pv = new Persona();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.id_Factura = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    v.Id_Vendedor = HelperDB.ObtenerInstancia().Dr.GetInt32(1);
                    c.id_vendedor = HelperDB.ObtenerInstancia().Dr.GetInt32(1);

                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    pv.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    pv.Apellido = HelperDB.ObtenerInstancia().Dr.GetString(3);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                {
                    cli.Id_Cliente = HelperDB.ObtenerInstancia().Dr.GetInt32(4);
                    c.id_cliente = HelperDB.ObtenerInstancia().Dr.GetInt32(1);

                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(5))
                {
                    pc.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(5);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(6))
                {
                    pc.Apellido = HelperDB.ObtenerInstancia().Dr.GetString(6);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(7))
                {
                    c.fecha_Pago = HelperDB.ObtenerInstancia().Dr.GetDateTime(7).ToShortDateString();
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(8))
                {
                    c.fecha_Reserva = HelperDB.ObtenerInstancia().Dr.GetDateTime(8).ToShortDateString();
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(9))
                {
                    c.id_Tipo_Compra = HelperDB.ObtenerInstancia().Dr.GetInt32(9);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(10))
                {
                    c.tipoCompra = HelperDB.ObtenerInstancia().Dr.GetString(10);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(11))
                {
                    c.id_Forma_Pago = HelperDB.ObtenerInstancia().Dr.GetInt32(11);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(12))
                {
                    c.formaPago = HelperDB.ObtenerInstancia().Dr.GetString(12);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(13))
                {
                    c.estado = HelperDB.ObtenerInstancia().Dr.GetInt32(13);
                }

                cli.per = pc;
                v.per = pv;
                c.cliente = cli;
                c.vendedor = v;

                LFactura.Add(c);
            }
            HelperDB.ObtenerInstancia().close();
            return LFactura;
        }
    }
}
