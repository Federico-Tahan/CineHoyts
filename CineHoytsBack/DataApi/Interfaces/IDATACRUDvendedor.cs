﻿using Cine_Hoyts.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineHoytsBack.DataApi.Interfaces
{
    public interface IDATACRUDvendedor
    {
        bool alta(Vendedor c);
        bool baja(int c);
        bool Modificacion(Vendedor c);
        List<Vendedor> Cargar_Vendedores();
        bool search_Vendedor(int c);
    }
}
