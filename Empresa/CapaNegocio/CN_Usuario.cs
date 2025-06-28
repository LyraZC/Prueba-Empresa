using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        /*Metodo para utilizar la lista de usuarios*/
        private CD_Usuario objcd_usuario = new CD_Usuario();

        public List<Usuario> Listar()
        {
            return objcd_usuario.Listar();
        }

        public Usuario Crear(Usuario usuario)
        {
            return objcd_usuario.Crear(usuario);
        }

    }
}
