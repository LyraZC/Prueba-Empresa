using CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using CapaEntidades;


namespace Presentacion
{
    public partial class Opciones_Producto : Form
    {
        private int _idProducto;
        private string _nombreProducto;

        public Opciones_Producto(int idProducto, string nombreProducto)
        {
            InitializeComponent();
            _idProducto = idProducto;
            _nombreProducto = nombreProducto;

            CargarOpcionesProducto();
        }

        private void CargarOpcionesProducto()
        {
            CN_Opcion cd = new CN_Opcion(); 
            List<Opciones> todasLasOpciones = cd.Listar();

            // Filtr5o solo las del producto actual
            var opcionesDelProducto = todasLasOpciones
                .Where(o => o.idNombreProducto == _idProducto)
                .ToList();

            // Asignar al ComboBox
            cbOpciones.DataSource = opcionesDelProducto;
            cbOpciones.DisplayMember = "Nombre";
            cbOpciones.ValueMember = "idOpcion";
        }

        private void Opciones_Producto_Load(object sender, EventArgs e)
        {

        }

        private void cbOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
