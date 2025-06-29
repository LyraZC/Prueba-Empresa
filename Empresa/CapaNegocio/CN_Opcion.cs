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

        public Opciones Crear(string nombre, int idProducto)
        {
            Opciones nueva = new Opciones
            {
                Nombre = nombre,
                idNombreProducto = idProducto
            };

            return objcd_opcion.Crear(nueva); 
        }

        public Opciones Editar(int idOpcion, string nuevoNombre)
        {
            return objcd_opcion.Editar(idOpcion, nuevoNombre);
        }

    }
}
