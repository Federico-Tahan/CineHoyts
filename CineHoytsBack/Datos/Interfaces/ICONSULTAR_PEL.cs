using Cine_Hoyts.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Hoyts.Datos.Interfaces
{
    public interface ICONSULTAR_PEL
    {

        List<Pelicula> peliculas();
        bool BajarPel(int pel);

        List<Pelicula> peliculas_Crud();

        List<Pelicula> peliculas_filter(string nombre);

        bool BuscarPel(int pel);
        bool Modificacion(Pelicula c);

        bool AltaPelicula(Pelicula c);



    }
}
