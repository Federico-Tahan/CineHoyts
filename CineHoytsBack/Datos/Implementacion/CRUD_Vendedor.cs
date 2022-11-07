using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cine_Hoyts.Datos;
using Cine_Hoyts.Dominio;
using CineHoytsBack.Datos.Interfaces;

namespace CineHoytsBack.Datos.Implementacion
{
    public class CRUD_Vendedor : ICRUD_Vendedor
    {
        public bool alta(Vendedor c)
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
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@usuario", c.Usuario);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@contraseña", c.Contraseña);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@admin", c.admin);
                HelperDB.ObtenerInstancia().updatear_db("SP_ALTA_Vendedor");
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool baja(int c)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_vendedor", c);
                HelperDB.ObtenerInstancia().updatear_db("SP_BAJA_Vendedor");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Vendedor> Cargar_Vendedores()
        {
            List<Vendedor> lven = new List<Vendedor>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_OBTENER_VendedorCrud");
            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Vendedor c = new Vendedor();
                Persona p = new Persona();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.Id_Vendedor = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
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
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(14))
                {
                    c.admin = HelperDB.ObtenerInstancia().Dr.GetInt32(14);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(15))
                {
                    c.Usuario = HelperDB.ObtenerInstancia().Dr.GetString(15);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(16))
                {
                    c.Contraseña = HelperDB.ObtenerInstancia().Dr.GetString(16);
                }
                c.per = p;
                lven.Add(c);
            }
            HelperDB.ObtenerInstancia().close();
            return lven;
        }

        public bool Modificacion(Vendedor c)
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
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@usuario", c.Usuario);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@contraseña", c.Contraseña);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@admin", c.admin);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_vendedor", c.Id_Vendedor);
                HelperDB.ObtenerInstancia().updatear_db("SP_MODIFY_vendedor");
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool search_Vendedor(int c)
        {
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_Vendedor", c);
            HelperDB.ObtenerInstancia().LeerDB("SP_BUSCAR_Vendedor");
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
