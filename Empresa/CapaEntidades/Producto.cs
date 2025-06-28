using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string Codigo  { get; set; }
        public string NombreProducto  { get; set; }
        public int Existencia  { get; set; }
        public bool Estado  { get; set; }
        public string Proveedor  { get; set; }
    }
}
