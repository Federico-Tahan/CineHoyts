using Cine_Hoyts.Datos.Interfaces;
using Cine_Hoyts.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cine_Hoyts.Datos;

namespace Cine_Hoyts.Datos.Implementacion
{
    public class Login : ILogIn
    {

        public bool Logeado(Vendedor v)
        {
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@usuario", v.Usuario);
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@contraseña", v.Contraseña);
            HelperDB.ObtenerInstancia().LeerDB("SP_USUARIO_PASS");

            if (HelperDB.ObtenerInstancia().Dr.Read())
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().close();
                return true;
            }
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().close();
            return false;
        }

        public Vendedor GetDatos(Vendedor v)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@usuario", v.Usuario);
                HelperDB.ObtenerInstancia().LeerDB("SP_OBTENER_VENDEDOR");
                HelperDB.ObtenerInstancia().Dr.Read();
                Persona p = new Persona();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                    {
                        v.Id_Vendedor = HelperDB.ObtenerInstancia().Dr.GetInt32(0);

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
                    v.admin = HelperDB.ObtenerInstancia().Dr.GetInt32(11);

                }
                v.per = p;
            }
            catch (Exception ex)
            {

            }
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().close();
            return v;


        }
    }
}

