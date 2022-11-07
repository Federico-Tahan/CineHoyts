using Cine_Hoyts.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineHoytsBack.DataApi.Interfaces
{
    public interface IDataPelicula
    {
        List<Pelicula> peliculas();
        List<Pelicula> peliculas_filter(string nombre);
        List<Pelicula> peliculas_Crud();
        bool BajaPel(int a);

        bool BuscarPel(int pel);
        bool Modificacion(Pelicula c);
        bool AltaPeli(Pelicula c);


    }
}
