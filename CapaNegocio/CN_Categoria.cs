﻿using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Categoria
    {
        private CD_Categoria objcd_categoria = new CD_Categoria();

        public List<Categoria> Listar()
        {
            return objcd_categoria.listar();
        }

        public int Registrar(Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesario la descripcion de la Categoria\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_categoria.Registrar(obj, out Mensaje);
            }
        }

        public bool Editar(Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesario la descripcion de la Categoria\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_categoria.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Categoria obj, out string Mensaje)
        {
            return objcd_categoria.Eliminar(obj, out Mensaje);
        }
    }
}