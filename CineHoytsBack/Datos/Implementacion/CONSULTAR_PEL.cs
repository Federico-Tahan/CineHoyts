using Cine_Hoyts.Datos.Interfaces;
using Cine_Hoyts.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Hoyts.Datos.Implementacion
{
    public class CONSULTAR_PEL: ICONSULTAR_PEL
    {

        public List<Pelicula> peliculas()
        {
            List<Pelicula> LPEL = new List<Pelicula>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_CARGAR_PELICULA");
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
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    c.Duracion = HelperDB.ObtenerInstancia().Dr.GetInt32(2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    c.productor = HelperDB.ObtenerInstancia().Dr.GetString(3);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                {
                    c.Edad = HelperDB.ObtenerInstancia().Dr.GetInt32(4);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(5))
                {
                    c.Espectadores = HelperDB.ObtenerInstancia().Dr.GetInt32(5);
                }
                LPEL.Add(c);
            }
            HelperDB.ObtenerInstancia().close();
            return LPEL;
        }

        public List<Pelicula> peliculas_filter(string nombre)
        {
            List<Pelicula> LPEL = new List<Pelicula>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nombre",nombre);
            HelperDB.ObtenerInstancia().LeerDB("SP_CARGAR_PELICULA_Nombre");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

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
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    c.Duracion = HelperDB.ObtenerInstancia().Dr.GetInt32(2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    c.productor = HelperDB.ObtenerInstancia().Dr.GetString(3);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                {
                    c.Edad = HelperDB.ObtenerInstancia().Dr.GetInt32(4);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(5))
                {
                    c.Espectadores = HelperDB.ObtenerInstancia().Dr.GetInt32(5);
                }
                LPEL.Add(c);
            }
            HelperDB.ObtenerInstancia().close();
            return LPEL;
        }

        public List<Pelicula> peliculas_Crud()
        {
            List<Pelicula> LPEL = new List<Pelicula>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_CARGAR_PELICULA_crud");
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
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    c.Duracion = HelperDB.ObtenerInstancia().Dr.GetInt32(2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    c.productor = HelperDB.ObtenerInstancia().Dr.GetString(3);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                {
                    c.Edad = HelperDB.ObtenerInstancia().Dr.GetInt32(4);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(5))
                {
                    c.id_edad = HelperDB.ObtenerInstancia().Dr.GetInt32(5);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(6))
                {
                    c.id_prod = HelperDB.ObtenerInstancia().Dr.GetInt32(6);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(7))
                {
                    c.Descripcion = HelperDB.ObtenerInstancia().Dr.GetString(7);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(8))
                {
                    c.Imagen = (byte[])HelperDB.ObtenerInstancia().Dr.GetValue(8);
                }
                LPEL.Add(c);
            }
            HelperDB.ObtenerInstancia().close();
            return LPEL;
        }

        public bool BajarPel(int pel)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_pel", pel);
                HelperDB.ObtenerInstancia().updatear_db("BAJAR_PELICULA");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool BuscarPel(int pel)
        {

            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_pel", pel);
            HelperDB.ObtenerInstancia().LeerDB("Buscar_Peli");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            if (HelperDB.ObtenerInstancia().Dr.Read())
            {
                return true;
                HelperDB.ObtenerInstancia().close();

            }
            HelperDB.ObtenerInstancia().close();
            return false;


        }


        public bool Modificacion(Pelicula c)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_pel", c.id_pel);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@titulo", c.Titulo);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@descripcion", c.Descripcion);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_restriccion", c.id_edad);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_productor", c.id_prod);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@duracion", c.Duracion);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@imagen", c.Imagen);
                HelperDB.ObtenerInstancia().updatear_db("Update_Peli");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool AltaPelicula(Pelicula c)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@titulo", c.Titulo);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@descripcion", c.Descripcion);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_restriccion", c.id_edad);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_productor", c.id_prod);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@duracion", c.Duracion);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@imagen", c.Imagen);
                HelperDB.ObtenerInstancia().updatear_db("InsertPeli");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
