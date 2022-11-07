using Cine_Hoyts;
using Cine_Hoyts.Datos.Implementacion;
using Cine_Hoyts.Datos.Interfaces;
using Cine_Hoyts.Dominio;
using CineHoytsBack.DataApi.Interfaces;
using CineHoytsBack.Datos.Implementacion;
using CineHoytsBack.Datos.Interfaces;
using CineHoytsBack.Dominio;
using CineHoytsBack.Dominio.Campos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineHoytsBack.DataApi.Implementacion
{
    public class DataTable:IDataTables
    {
        private ITablas lg;
        public DataTable()
        {
            lg = new Tabla();
        }

        public bool Alta_Fun(Funcion fun)
        {
            return lg.Alta_fun(fun);
        }

        public bool Bajar_Fun(Parametro p)
        {
            return lg.Baja_funcion(p);
        }

        public bool Bajar_Fun(int A)
        {
            return lg.Baja_Fun(A);
        }

        public bool buscar_fun(int fun)
        {
            return lg.buscar_fun(fun);
        }

        public List<Barrio> ObtenerBarrios(int CodigoLocalidad)
        {
            return lg.ObtenerBarrios(CodigoLocalidad);
        }

        public List<Cliente> ObtenerClienteCbo()
        {
            return lg.ObtenerClientesCBO();
        }

        public List<Fecha> ObtenerFecha(List<Parametro> pm)
        {
            return lg.ObtenerFecha(pm);
        }

        public List<FormaPago> ObtenerFormaPago()
        {
            return lg.ObtenerFormaPago();
        }

        public Funcion obtenerFuncion(List<Parametro> pm)
        {
            return lg.ObtenerFuncion(pm);
        }

        public int obtenerFuncion()
        {
            return lg.ObtenerEntrada();
        }

        public List<Funcion> ObtenerFunciones()
        {
            return lg.ObtenerFunciones();
        }

        public List<Hora> ObtenerHorario(List<Parametro> pm)
        {
            return lg.ObtenerHorario(pm);
        }

        public List<Hora> ObtenerHorario_cbo_fun()
        {
            return lg.ObtenerHorario_fun();
        }

        public List<Idioma> ObtenerIdioma_cbo_fun()
        {
            return lg.ObtenerIdioma_cbo_fun();
        }

        public List<Idioma> obteneridoma(List<Parametro> pm)
        {
            return lg.ObtenerIdioma(pm);
        }

        public byte[] obtenerImage()
        {
            return lg.ObtenerImagen();
        }

        public List<Localidad> ObtenerLocalidades(Parametro codigoProvincia)
        {
            return lg.ObtenerLocalidades(codigoProvincia);
        }

        public List<Pelicula> ObtenerPeliculaboCrud()
        {
            return lg.ObtenerPeliculaCbo();
        }

        public List<Pelicula> ObtenerPeliculaCBO()
        {
            return lg.ObtenerPelicula();
        }

        public List<Provincia> ObtenerProvincias()
        {
            return lg.ObtenerProvincias();
        }

        public List<Produccion> ObtenerprudoccionCBO()
        {
            return lg.ObtenerProduccion();
        }

        public double obtenerRecaudado()
        {
            return lg.ObtenerRecaudado();
        }

        public List<restriccion> ObtenerrestriccionCBO()
        {
            return lg.Obtenerrestriccion();
        }

        public List<TipoCompra> ObtenerTipoCompraCBO()
        {
            return lg.ObtenerTipoCompraCBO();
        }

        public List<TipoDoc> ObtenerTipoDoc()
        {
            return lg.ObtenerTipoDoc();
        }

        public List<TipoSala> obtenerTipoSala(List<Parametro> pm)
        {
            return lg.ObtenerTipoSala(pm);
        }

        public List<TipoSala> obtenerTipoSalacbo()
        {
            return lg.ObtenerSalaCboFun();
        }

        public List<Vendedor> ObtenerVendedorCbo()
        {


            return lg.ObtenerVendedoresCBO();
        }

        public bool Update_Fun(Funcion fun)
        {
            return lg.updatefun(fun);
        }
    }
}
