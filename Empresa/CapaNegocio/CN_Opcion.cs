using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class CN_Opcion
    {
        /*Metodo para utilizar la lista de Opciones*/
        private CD_Opciones objcd_opcion = new CD_Opciones();

        public List<Opciones> Listar()
        {
            return objcd_opcion.Listar();
        }

    }
}
