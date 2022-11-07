using Cine_Hoyts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineHoytsBack.Dominio;
using CineHoytsBack.Dominio.Campos;
using Cine_Hoyts.Dominio;

namespace CineHoytsBack.Datos.Interfaces
{
    public interface ITablas
    {
        List<Provincia> ObtenerProvincias();
        List<Localidad> ObtenerLocalidades(Parametro p);
        List<Barrio> ObtenerBarrios(int CodigoLocalidad);

        List<TipoDoc> ObtenerTipoDoc();
        List<FormaPago> ObtenerFormaPago();
        List<Cliente> ObtenerClientesCBO();
        List<Vendedor> ObtenerVendedoresCBO();
        List<TipoCompra> ObtenerTipoCompraCBO();
        List<Produccion> ObtenerProduccion();
        List<restriccion> Obtenerrestriccion();
        List<Pelicula> ObtenerPelicula();
        List<Fecha> ObtenerFecha(List<Parametro> pm);
        List<Hora> ObtenerHorario(List<Parametro> pm);
        List<Idioma> ObtenerIdioma(List<Parametro> pm);
        List<TipoSala> ObtenerTipoSala(List<Parametro> pm);
        Funcion ObtenerFuncion(List<Parametro> pm);
        int ObtenerEntrada();
        double ObtenerRecaudado();
        byte[] ObtenerImagen();

        bool Baja_funcion(Parametro p);

        List<Pelicula> ObtenerPeliculaCbo();
        List<Idioma> ObtenerIdioma_cbo_fun();
        List<Hora> ObtenerHorario_fun();
        List<TipoSala> ObtenerSalaCboFun();

        List<Funcion> ObtenerFunciones();
        bool Baja_Fun(int a);

        bool Alta_fun(Funcion f);
        bool updatefun(Funcion f);
        bool buscar_fun(int f);


























    }
}
