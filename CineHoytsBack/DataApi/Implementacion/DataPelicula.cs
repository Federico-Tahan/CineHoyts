using Cine_Hoyts.Datos.Implementacion;
using Cine_Hoyts.Datos.Interfaces;
using Cine_Hoyts.Dominio;
using CineHoytsBack.DataApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineHoytsBack.DataApi.Implementacion
{
    public class DataPelicula:IDataPelicula
    {
        private ICONSULTAR_PEL lg;
        public DataPelicula()
        {
            lg = new CONSULTAR_PEL();
        }

        public bool AltaPeli(Pelicula c)
        {
            return lg.AltaPelicula(c);
        }

        public bool BajaPel(int a)
        {
            return lg.BajarPel(a);
        }

        public bool BuscarPel(int pel)
        {
            return lg.BuscarPel(pel);
        }

        public bool Modificacion(Pelicula c)
        {
            return lg.Modificacion(c);
        }

        public List<Pelicula> peliculas()
        {
            return lg.peliculas();
        }

        public List<Pelicula> peliculas_Crud()
        {
            return lg.peliculas_Crud();
        }

        public List<Pelicula> peliculas_filter(string nombre)
        {
            return lg.peliculas_filter(nombre);
        }
    }
}
