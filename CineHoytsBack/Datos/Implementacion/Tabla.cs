using Cine_Hoyts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cine_Hoyts.Datos;
using CineHoytsBack.Datos.Interfaces;
using Cine_Hoyts.Dominio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using CineHoytsBack.Properties;
using CineHoytsBack.Dominio;
using CineHoytsBack.Dominio.Campos;

namespace CineHoytsBack.Datos.Implementacion
{
    public class Tabla:ITablas
    {
        public List<Provincia> ObtenerProvincias()
        {
            List<Provincia> lstprovincia = new List<Provincia>();
            using (SqlConnection oConexion = new SqlConnection(Resources.Connection))
            {
                SqlCommand cmd = new SqlCommand("sp_obtener_provincia", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 600;
                oConexion.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lstprovincia.Add(new Provincia
                    {
                        codigo_provincia = Convert.ToInt32(dr["id_provincia"]),
                        nombre_provincia = Convert.ToString(dr["provincia"].ToString())
                    });

                }
                HelperDB.ObtenerInstancia().close();


            }

            return lstprovincia;
        }

        public List<Localidad> ObtenerLocalidades(Parametro p)
        {
            List<Localidad> lstlocalidad = new List<Localidad>();
            using (SqlConnection oConexion = new SqlConnection(Resources.Connection))
            {
                SqlCommand cmd = new SqlCommand("sp_obtener_localidad", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(p.Clave, Convert.ToInt32(p.Valor.ToString()));
                cmd.CommandTimeout = 600;
                oConexion.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lstlocalidad.Add(new Localidad
                    {
                        codigo_localidad = Convert.ToInt32(dr["id_localidad"]),
                        nombre_localidad = Convert.ToString(dr["localidad"].ToString())
                    });

                }
                HelperDB.ObtenerInstancia().close();


            }

            return lstlocalidad;

        }

        public List<Barrio> ObtenerBarrios(int CodigoLocalidad)
        {
            List<Barrio> lstbarrios = new List<Barrio>();
            using (SqlConnection oConexion = new SqlConnection(Resources.Connection))
            {
                HelperDB.ObtenerInstancia().Command.CommandTimeout = 600;
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("id_localidad", Convert.ToInt32(CodigoLocalidad));
                HelperDB.ObtenerInstancia().LeerDB("sp_obtener_barrio");


                while (HelperDB.ObtenerInstancia().Dr.Read())
                {
                    lstbarrios.Add(new Barrio
                    {
                        codigo_barrio = Convert.ToInt32(HelperDB.ObtenerInstancia().Dr["id_barrio"]),
                        nombre_barrio = Convert.ToString(HelperDB.ObtenerInstancia().Dr["barrio"].ToString())
                    });

                }
                HelperDB.ObtenerInstancia().close();


            }

            return lstbarrios;

        }

        public List<TipoDoc> ObtenerTipoDoc()
        {
            List<TipoDoc> td = new List<TipoDoc>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_CBO_TIPO_DOC");

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                TipoDoc tipoDoc = new TipoDoc();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    tipoDoc.IdTipoDoc = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    tipoDoc.TipoDocumento = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                td.Add(tipoDoc);
            }
            HelperDB.ObtenerInstancia().close();

            return td;

        }


        public List<FormaPago> ObtenerFormaPago()
        {
            List<FormaPago> td = new List<FormaPago>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_CARGA_FORMA_PAGO");

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                FormaPago FPago = new FormaPago();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    FPago.IdFormaPago = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    FPago.Formapago = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                td.Add(FPago);
            }
            HelperDB.ObtenerInstancia().close();

            return td;
        }

        public List<Cliente> ObtenerClientesCBO()
        {
            List<Cliente> td = new List<Cliente>(); HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_CARGA_CBO_CLIENT");

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Cliente c = new Cliente();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.Id_Cliente = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    c.NombreCBO = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                td.Add(c);
            }
            HelperDB.ObtenerInstancia().close();

            return td;
        }

        public List<Vendedor> ObtenerVendedoresCBO()
        {
            List<Vendedor> td = new List<Vendedor>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_CARGA_CBO_VENDEDOR");

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Vendedor c = new Vendedor();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.Id_Vendedor = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    c.nombreCBO = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                td.Add(c);
            }
            HelperDB.ObtenerInstancia().close();

            return td;
        }

        public List<TipoCompra> ObtenerTipoCompraCBO()
        {
            List<TipoCompra> td = new List<TipoCompra>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_CARGA_TIPO_COMPRA");

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                TipoCompra c = new TipoCompra();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.Id_tipoCompra = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    c.TipocOMRPA = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                td.Add(c);
            }
            HelperDB.ObtenerInstancia().close();

            return td;
        }

        public List<Produccion> ObtenerProduccion()
        {
            List<Produccion> td = new List<Produccion>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_CARGA_PROD");

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Produccion c = new Produccion();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.Id_produccion = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    c.produccion = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                td.Add(c);
            }
            HelperDB.ObtenerInstancia().close();

            return td;
        }

        public List<restriccion> Obtenerrestriccion()
        {
            List<restriccion> td = new List<restriccion>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_CARGA_RESTRICCION");

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                restriccion c = new restriccion();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.Id_Restriccion = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    c.Restriccion = HelperDB.ObtenerInstancia().Dr.GetInt32(1);
                }
                td.Add(c);
            }
            HelperDB.ObtenerInstancia().close();

            return td;
        }

        public List<Pelicula> ObtenerPelicula()
        {
            List<Pelicula> td = new List<Pelicula>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_BUSCAR_PELICULAS");

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Pelicula c = new Pelicula();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.id_pel = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    c.Titulo = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                td.Add(c);
            }
            HelperDB.ObtenerInstancia().close();

            return td;
        }
        public List<Fecha> ObtenerFecha(List<Parametro> pm)
        {
            List<Fecha> td = new List<Fecha>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue(pm[0].Clave, Convert.ToInt32(pm[0].Valor.ToString()));
            HelperDB.ObtenerInstancia().LeerDB("SP_CARGAR_FECHAS");

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Fecha c = new Fecha();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.fecha = HelperDB.ObtenerInstancia().Dr.GetString(0);
                }

                td.Add(c);
            }
            HelperDB.ObtenerInstancia().close();

            return td;
        }

        public List<Hora> ObtenerHorario(List<Parametro> pm)
        {
            List<Hora> td = new List<Hora>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue(pm[0].Clave, Convert.ToInt32(pm[0].Valor.ToString()));
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue(pm[1].Clave, Convert.ToDateTime(pm[1].Valor.ToString()));

            HelperDB.ObtenerInstancia().LeerDB("SP_CARGAR_HORARIOS");

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Hora c = new Hora();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.id_hora = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    c.Horario = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }

                td.Add(c);
            }
            HelperDB.ObtenerInstancia().close();

            return td;
        }

        public List<Idioma> ObtenerIdioma(List<Parametro> pm)
        {
            List<Idioma> td = new List<Idioma>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue(pm[0].Clave, Convert.ToInt32(pm[0].Valor.ToString()));
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue(pm[1].Clave, Convert.ToDateTime(pm[1].Valor.ToString()));
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue(pm[2].Clave, Convert.ToInt32(pm[2].Valor.ToString()));
            HelperDB.ObtenerInstancia().LeerDB("SP_CARGAR_IDIOMAS_FUN");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Idioma c = new Idioma();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.id_idioma = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    c.idiom = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }

                td.Add(c);
            }
            HelperDB.ObtenerInstancia().close();

            return td;
        }

        public List<TipoSala> ObtenerTipoSala(List<Parametro> pm)
        {
            List<TipoSala> td = new List<TipoSala>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue(pm[0].Clave, Convert.ToInt32(pm[0].Valor.ToString()));
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue(pm[1].Clave, Convert.ToDateTime(pm[1].Valor.ToString()));
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue(pm[2].Clave, Convert.ToInt32(pm[2].Valor.ToString()));
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue(pm[3].Clave, Convert.ToInt32(pm[3].Valor.ToString()));

            HelperDB.ObtenerInstancia().LeerDB("SP_CARGAR_TIPO_SALA");

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                TipoSala c = new TipoSala();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.id_tipoSala = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    c.tiposala = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }

                td.Add(c);
            }
            HelperDB.ObtenerInstancia().close();

            return td;
        }

        public Funcion ObtenerFuncion(List<Parametro> pm)
        {
            Funcion f = new Funcion();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue(pm[0].Clave, Convert.ToInt32(pm[0].Valor.ToString()));
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue(pm[1].Clave, Convert.ToDateTime(pm[1].Valor.ToString()));
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue(pm[2].Clave, Convert.ToInt32(pm[2].Valor.ToString()));
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue(pm[3].Clave, Convert.ToInt32(pm[3].Valor.ToString()));
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue(pm[4].Clave, Convert.ToInt32(pm[4].Valor.ToString()));

            HelperDB.ObtenerInstancia().LeerDB("SP_CARGAR_ID_FUNCION");

            Funcion c = new Funcion();

            if (HelperDB.ObtenerInstancia().Dr.Read())
            {
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.id_funcion = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    c.monto = Convert.ToDouble(HelperDB.ObtenerInstancia().Dr.GetDecimal(1));
                }
            }
            HelperDB.ObtenerInstancia().close();
            return c;
        }

        public int ObtenerEntrada()
        {
            int num = 0;
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_TICKETS_DIARIO");

             if (HelperDB.ObtenerInstancia().Dr.Read())
             {
                 num = Convert.ToInt32(HelperDB.ObtenerInstancia().Dr.GetValue(0));

             }

            HelperDB.ObtenerInstancia().close();
            return num;
        }

        public double ObtenerRecaudado()
        {
            double num = 0;
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_MONTO_DIARIO");

            if (HelperDB.ObtenerInstancia().Dr.Read())
            {
                num = Convert.ToInt32(HelperDB.ObtenerInstancia().Dr.GetValue(0));

            }
            HelperDB.ObtenerInstancia().close();
            return num;
        }

        public byte[] ObtenerImagen()
        {
            byte[] image = null;
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_MEJOR_PELICULA");
            if (HelperDB.ObtenerInstancia().Dr.Read())
            {
                image = (byte[])HelperDB.ObtenerInstancia().Dr.GetValue(0);

            }
            HelperDB.ObtenerInstancia().close();
            return image;

        }

        public bool Baja_funcion(Parametro p)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue(p.Clave, Convert.ToDateTime(p.Valor.ToString()));
                HelperDB.ObtenerInstancia().updatear_db("SP_BAJAR_FUNCIONES");
                HelperDB.ObtenerInstancia().updatear_db("SP_BAJA_FACTURA");
                return true;
            }
            catch
            {
                return false;

            }

        }

        public List<Pelicula> ObtenerPeliculaCbo()
        {
            List<Pelicula> lp = new List<Pelicula>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_OBTENER_PELISCBO");

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Pelicula p = new Pelicula();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    p.id_pel = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    p.Titulo = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                lp.Add(p);
            }
            HelperDB.ObtenerInstancia().close();
            return lp;
        }

        public List<Idioma> ObtenerIdioma_cbo_fun()
        {
            List<Idioma> td = new List<Idioma>();
            HelperDB.ObtenerInstancia().LeerDB("SP_CARGAR_IDIOMAS");

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Idioma c = new Idioma();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.id_idioma = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    c.idiom = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }

                td.Add(c);
            }
            HelperDB.ObtenerInstancia().close();

            return td;
        }

        public List<Hora> ObtenerHorario_fun()
        {
            List<Hora> td = new List<Hora>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            HelperDB.ObtenerInstancia().LeerDB("SP_cARGAR_HORARIO");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();


            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Hora c = new Hora();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.id_hora = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    c.Horario = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }

                td.Add(c);
            }
            HelperDB.ObtenerInstancia().close();

            return td;
        }

        public List<TipoSala> ObtenerSalaCboFun()
        {
            List<TipoSala> td = new List<TipoSala>();
            HelperDB.ObtenerInstancia().LeerDB("SP_TIPO_SALA");

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                TipoSala c = new TipoSala();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.id_tipoSala = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    c.tiposala = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }

                td.Add(c);
            }
            HelperDB.ObtenerInstancia().close();

            return td;
        }

        public List<Funcion> ObtenerFunciones()
        {
            List<Funcion> td = new List<Funcion>();
            HelperDB.ObtenerInstancia().LeerDB("OBTENER_FUNCIONES");

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Funcion c = new Funcion();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.id_funcion = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    c.Fecha = HelperDB.ObtenerInstancia().Dr.GetDateTime(1).ToString("dd/MM/yyyy");
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    c.Id_idioma = HelperDB.ObtenerInstancia().Dr.GetInt32(2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    c.Idioma = HelperDB.ObtenerInstancia().Dr.GetString(3);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                {
                    c.Id_pelicula = HelperDB.ObtenerInstancia().Dr.GetInt32(4);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(5))
                {
                    c.Pelicula = HelperDB.ObtenerInstancia().Dr.GetString(5);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(6))
                {
                    c.Id_sala = HelperDB.ObtenerInstancia().Dr.GetInt32(6);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(7))
                {
                    c.Sala = HelperDB.ObtenerInstancia().Dr.GetString(7);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(8))
                {
                    c.Id_horario = HelperDB.ObtenerInstancia().Dr.GetInt32(8);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(9))
                {
                    c.Hora = HelperDB.ObtenerInstancia().Dr.GetString(9);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(10))
                {
                    c.monto = Convert.ToDouble(HelperDB.ObtenerInstancia().Dr.GetDecimal(10));
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(11))
                {
                    c.Id_TipoSala = HelperDB.ObtenerInstancia().Dr.GetInt32(11);
                }
                td.Add(c);
            }
            HelperDB.ObtenerInstancia().close();

            return td;
        }

        public bool Baja_Fun(int pel)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_fun", pel);
                HelperDB.ObtenerInstancia().updatear_db("Bajar_Fun");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Alta_fun(Funcion f)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@FECHA", Convert.ToDateTime(f.Fecha));
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@ID_IDIOMA", f.Id_idioma);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@ID_PELICULA", f.Id_pelicula);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@ID_SALA", f.Id_sala);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@ID_HORARIO", f.Id_horario);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@MONTO", f.monto);
                HelperDB.ObtenerInstancia().updatear_db("SP_INSER_FUN");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool updatefun(Funcion f)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_funcion", f.id_funcion);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@FECHA", Convert.ToDateTime(f.Fecha));
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@ID_IDIOMA", f.Id_idioma);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@ID_PELICULA", f.Id_pelicula);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@ID_SALA", f.Id_sala);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@ID_HORARIO", f.Id_horario);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@MONTO", f.monto);
                HelperDB.ObtenerInstancia().updatear_db("SP_update_FUN");
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool buscar_fun(int f)
        {
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_fun", f);
            HelperDB.ObtenerInstancia().LeerDB("buscar_Fun");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            if (HelperDB.ObtenerInstancia().Dr.Read())
            {
                HelperDB.ObtenerInstancia().close();
                return true;
            }
            HelperDB.ObtenerInstancia().close();
            return false;
        }
    }
}
