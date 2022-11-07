using Cine_Hoyts.Datos.Interfaces;
using Cine_Hoyts.Dominio;
using CineHoytsBack.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Hoyts.Datos.Implementacion
{
    public class CRUD_CLIENTE : ICRUD_Cliente
    {
        public bool alta(Cliente c)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nombre", c.per.Nombre);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@apellido", c.per.Apellido);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@direccion", c.per.Direccion);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nro_direccion", c.per.Nro_Direccion);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_barrio", c.per.id_barrio);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_tipo_doc", c.per.Id_tipo_documento);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nro_doc", c.per.Nro_Documento);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@fecha_nacimiento", Convert.ToDateTime(c.per.Fecha_Nac));
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@Sexo", c.per.Sexo);
                HelperDB.ObtenerInstancia().updatear_db("SP_ALTA_CLIENTE");
                return true;

            }
            catch(Exception ex)
            {
                return false;
            }



        }

        public bool baja(Parametro c)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_cliente", Convert.ToInt32(c.Valor.ToString()));
                HelperDB.ObtenerInstancia().updatear_db("SP_BAJA_CLIENTE");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Cliente> Cargar_Clientes()
        {
            List<Cliente> lCliente = new List<Cliente>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_OBTENER_CLIENTE");
            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Cliente c = new Cliente();
                Persona p = new Persona();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.Id_Cliente = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    p.Id_Persona = HelperDB.ObtenerInstancia().Dr.GetInt32(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    p.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    p.Apellido = HelperDB.ObtenerInstancia().Dr.GetString(3);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                {
                    p.Direccion = HelperDB.ObtenerInstancia().Dr.GetString(4);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(5))
                {
                    p.Nro_Direccion = HelperDB.ObtenerInstancia().Dr.GetInt32(5);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(6))
                {
                    p.id_barrio = HelperDB.ObtenerInstancia().Dr.GetInt32(6);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(7))
                {
                    p.Nro_Documento = HelperDB.ObtenerInstancia().Dr.GetInt64(7);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(8))
                {
                    p.Id_tipo_documento = HelperDB.ObtenerInstancia().Dr.GetInt32(8);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(9))
                {
                    p.Fecha_Nac = HelperDB.ObtenerInstancia().Dr.GetDateTime(9).ToShortDateString();
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(10))
                {
                    p.Sexo = HelperDB.ObtenerInstancia().Dr.GetInt32(10);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(11))
                {
                    p.Tipo_doc = HelperDB.ObtenerInstancia().Dr.GetString(11);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(12))
                {
                    p.id_provincia = HelperDB.ObtenerInstancia().Dr.GetInt32(12);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(13))
                {
                    p.id_localidad = HelperDB.ObtenerInstancia().Dr.GetInt32(13);
                }
                c.per = p;
                lCliente.Add(c);
            }
            HelperDB.ObtenerInstancia().close();
            return lCliente;
        }

        public bool Modificacion(Cliente c)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_persona", c.per.Id_Persona);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@direccion", c.per.Direccion);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nro_direccion", c.per.Nro_Direccion);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_barrio", c.per.id_barrio);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_tipo_doc", c.per.Id_tipo_documento);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nro_doc", c.per.Nro_Documento);
                HelperDB.ObtenerInstancia().updatear_db("SP_MODIFY_CLIENTE");
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool search_cliente(int c)
        {
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_cliente",c);
            HelperDB.ObtenerInstancia().LeerDB("SP_BUSCAR_CLIENTE");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            if (HelperDB.ObtenerInstancia().Dr.Read())
            {
                HelperDB.ObtenerInstancia().close();
                return true;
            }
            HelperDB.ObtenerInstancia().close();
            return false;
        }

        public List<Cliente> Cargar_Clientes_ConVentas()
        {
            List<Cliente> lCliente = new List<Cliente>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_CARGAR_GRILLA_CLIENTE");
            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Cliente c = new Cliente();
                Persona p = new Persona();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.Id_Cliente = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    p.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    p.Apellido = HelperDB.ObtenerInstancia().Dr.GetString(2);
                }

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    p.Nro_Documento = HelperDB.ObtenerInstancia().Dr.GetInt64(3);
                }

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                {
                    p.Fecha_Nac = HelperDB.ObtenerInstancia().Dr.GetDateTime(4).ToShortDateString();
                }

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(5))
                {
                    p.Sexo = HelperDB.ObtenerInstancia().Dr.GetInt32(5);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(6))
                {
                    p.Id_tipo_documento = HelperDB.ObtenerInstancia().Dr.GetInt32(6);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(7))
                {
                    c.TotalGastado = Convert.ToDouble(HelperDB.ObtenerInstancia().Dr.GetValue(7));
                }
                c.per = p;

                lCliente.Add(c);
            }
            HelperDB.ObtenerInstancia().close();
            return lCliente;
        }

        public List<Cliente> Cargar_Clientes_ConVentas_rango(List<Parametro> pm)
        {
            List<Cliente> lCliente = new List<Cliente>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue(pm[0].Clave, Convert.ToDateTime(pm[0].Valor.ToString()));
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue(pm[1].Clave, Convert.ToDateTime(pm[1].Valor.ToString()));

            HelperDB.ObtenerInstancia().LeerDB("sp_filtro_cliente_fec");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Cliente c = new Cliente();
                Persona p = new Persona();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.Id_Cliente = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    p.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    p.Apellido = HelperDB.ObtenerInstancia().Dr.GetString(2);
                }

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    p.Nro_Documento = HelperDB.ObtenerInstancia().Dr.GetInt64(3);
                }

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                {
                    p.Fecha_Nac = HelperDB.ObtenerInstancia().Dr.GetDateTime(4).ToShortDateString();
                }

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(5))
                {
                    p.Sexo = HelperDB.ObtenerInstancia().Dr.GetInt32(5);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(6))
                {
                    p.Id_tipo_documento = HelperDB.ObtenerInstancia().Dr.GetInt32(6);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(7))
                {
                    c.TotalGastado = Convert.ToDouble(HelperDB.ObtenerInstancia().Dr.GetValue(7));
                }
                c.per = p;

                lCliente.Add(c);
            }
            HelperDB.ObtenerInstancia().close();
            return lCliente;
        }

        public List<Cliente> Cargar_Clientes_ConVentas_rango_filtro(List<Parametro> pm)
        {
            List<Cliente> lCliente = new List<Cliente>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue(pm[0].Clave, Convert.ToDateTime(pm[0].Valor.ToString()));
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue(pm[1].Clave, Convert.ToDateTime(pm[1].Valor.ToString()));
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue(pm[2].Clave,pm[2].Valor.ToString());


            HelperDB.ObtenerInstancia().LeerDB("sp_filtro_cliente_fec_filter");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Cliente c = new Cliente();
                Persona p = new Persona();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.Id_Cliente = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    p.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    p.Apellido = HelperDB.ObtenerInstancia().Dr.GetString(2);
                }

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    p.Nro_Documento = HelperDB.ObtenerInstancia().Dr.GetInt64(3);
                }

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                {
                    p.Fecha_Nac = HelperDB.ObtenerInstancia().Dr.GetDateTime(4).ToShortDateString();
                }

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(5))
                {
                    p.Sexo = HelperDB.ObtenerInstancia().Dr.GetInt32(5);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(6))
                {
                    p.Id_tipo_documento = HelperDB.ObtenerInstancia().Dr.GetInt32(6);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(7))
                {
                    c.TotalGastado = Convert.ToDouble(HelperDB.ObtenerInstancia().Dr.GetValue(7));
                }
                c.per = p;

                lCliente.Add(c);
            }
            HelperDB.ObtenerInstancia().close();
            return lCliente;
        }



        public List<Cliente> Cargar_Clientes_ConVentas_Name(Parametro pm)
        {
            List<Cliente> lCliente = new List<Cliente>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue(pm.Clave, pm.Valor.ToString());
            HelperDB.ObtenerInstancia().LeerDB("SP_CARGAR_GRILLA_CLIENTE_nombre");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Cliente c = new Cliente();
                Persona p = new Persona();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.Id_Cliente = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    p.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    p.Apellido = HelperDB.ObtenerInstancia().Dr.GetString(2);
                }

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    p.Nro_Documento = HelperDB.ObtenerInstancia().Dr.GetInt64(3);
                }

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                {
                    p.Fecha_Nac = HelperDB.ObtenerInstancia().Dr.GetDateTime(4).ToShortDateString();
                }

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(5))
                {
                    p.Sexo = HelperDB.ObtenerInstancia().Dr.GetInt32(5);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(6))
                {
                    p.Id_tipo_documento = HelperDB.ObtenerInstancia().Dr.GetInt32(6);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(7))
                {
                    c.TotalGastado = Convert.ToDouble(HelperDB.ObtenerInstancia().Dr.GetValue(7));
                }
                c.per = p;

                lCliente.Add(c);
            }
            HelperDB.ObtenerInstancia().close();
            return lCliente;
        }
    }
}
