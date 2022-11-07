using Cine_Hoyts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineHoytsBack.Dominio;
using CineHoytsBack.Dominio.Campos;
using Cine_Hoyts.Dominio;

namespace CineHoytsBack.DataApi.Interfaces
{
    public interface IDataTables
    {
        List<Provincia> ObtenerProvincias();
        List<Localidad> ObtenerLocalidades(Parametro codigoProvincia);
        List<Barrio> ObtenerBarrios(int CodigoLocalidad);
        List<TipoDoc> ObtenerTipoDoc();
        List<FormaPago> ObtenerFormaPago();
        List<Cliente> ObtenerClienteCbo();
        List<Vendedor> ObtenerVendedorCbo();
        List<TipoCompra> ObtenerTipoCompraCBO();
        List<Produccion> ObtenerprudoccionCBO();
        List<restriccion> ObtenerrestriccionCBO();
        List<Pelicula> ObtenerPeliculaCBO();
        List<Fecha> ObtenerFecha(List<Parametro> pm);
        List<Hora> ObtenerHorario(List<Parametro> pm);
        List<Idioma> obteneridoma(List<Parametro> pm);

        List<TipoSala> obtenerTipoSala(List<Parametro> pm);
        Funcion obtenerFuncion(List<Parametro> pm);
        int obtenerFuncion();
        double obtenerRecaudado();
        byte[] obtenerImage();
        bool Bajar_Fun(Parametro p);
        List<Pelicula> ObtenerPeliculaboCrud();

        List<Idioma> ObtenerIdioma_cbo_fun();
        List<Hora> ObtenerHorario_cbo_fun();

        List<TipoSala> obtenerTipoSalacbo();

        List<Funcion> ObtenerFunciones();

        bool Bajar_Fun(int A);

        bool Alta_Fun(Funcion fun);
        bool Update_Fun(Funcion fun);
        bool buscar_fun(int fun);



















    }
}
