﻿using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario objcd_usuario = new CD_Usuario();

        public List<Usuario> Listar()
        {
            return objcd_usuario.listar();
        }

        public int Registrar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario el documento del usuario\n";
            }
            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es necesario el Nombre Completo del usuario\n";
            }
            if (obj.Clave == "")
            {
                Mensaje += "Es necesario el Clave del usuario\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_usuario.Registrar(obj, out Mensaje);
            }
        }

        public bool Editar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario el documento del usuario\n";
            }
            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es necesario el Nombre Completo del usuario\n";
            }
            if (obj.Clave == "")
            {
                Mensaje += "Es necesario el Clave del usuario\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_usuario.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            return objcd_usuario.Eliminar(obj, out Mensaje);
        }
    }
}