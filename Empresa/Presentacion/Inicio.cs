using CapaEntidades;
using CapaNegocio;
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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            
            //CN_Producto datos = new CN_Producto();
            //List<Producto> lista = datos.Listar();

            cbFIltro.Items.Add("Ninguno");   // índice 0
            cbFIltro.Items.Add("Activo");    // índice 1
            cbFIltro.Items.Add("Inactivo");  // índice 2
            cbFIltro.SelectedIndex = 0;      // por defecto "Ninguno"

            // Cargar todos los productos
            CargarProductos();
        }

        private void CargarProductos(string estado = "Ninguno", string nombreFiltro = "")
        {
            CN_Producto datos = new CN_Producto();
            List<Producto> lista = datos.Listar();

            // Filtrar si se selecciona algo diferente de "Ninguno"
            if (estado == "Activo")
                lista = lista.Where(p => p.Estado == true).ToList();
            else if (estado == "Inactivo")
                lista = lista.Where(p => p.Estado == false).ToList();

            // Filtro por nombre 
            if (!string.IsNullOrWhiteSpace(nombreFiltro))
                lista = lista.Where(p => p.NombreProducto.IndexOf(nombreFiltro, StringComparison.OrdinalIgnoreCase) >= 0).ToList();


            // Cargar en DataGridView con columna Estado como texto
            dataGridView1.DataSource = lista.Select(p => new
            {
                p.idProducto,
                p.Codigo,
                p.NombreProducto,
                p.Existencia,
                p.Proveedor,
                Estado = p.Estado ? "Activo" : "Inactivo"
            }).ToList();
        }

        private void cbFIltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estadoSeleccionado = cbFIltro.SelectedItem?.ToString() ?? "Ninguno";
            string nombre = txtBuscar.Text.Trim();
            CargarProductos(estadoSeleccionado, nombre);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string estadoSeleccionado = cbFIltro.SelectedItem?.ToString() ?? "Ninguno";
            string nombre = txtBuscar.Text.Trim();
            CargarProductos(estadoSeleccionado, nombre);
        }
    }
}
