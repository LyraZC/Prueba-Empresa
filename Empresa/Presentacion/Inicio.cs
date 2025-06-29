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
        private Usuario _usuarioActivo;

        public Inicio(Usuario usuario)
        {
            InitializeComponent();
            _usuarioActivo = usuario;
            
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            lbuser.Text = _usuarioActivo.NombreUsuario;

            cbFIltro.Items.Add("Ninguno");   // índice 0
            cbFIltro.Items.Add("Activo");    // índice 1
            cbFIltro.Items.Add("Inactivo");  // índice 2
            cbFIltro.SelectedIndex = 0;      // por defecto "Ninguno"

            // Cargar todos los productos
            CargarProductos();
            AgregarBotonOpciones();
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

        private void AgregarBotonOpciones()
        {
            if (!dataGridView1.Columns.Contains("btnOpciones"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "Opciones";
                btn.Text = "Ver";
                btn.Name = "btnOpciones";
                btn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btn);
            }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evitar errores si se hace clic en el encabezado
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "btnOpciones")
            {
                // Obtener el ID y nombre del producto seleccionado
                int idProducto = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idProducto"].Value);
                string nombreProducto = dataGridView1.Rows[e.RowIndex].Cells["NombreProducto"].Value.ToString();

                // Abrir el formulario de opciones
                Opciones_Producto form = new Opciones_Producto(idProducto, nombreProducto);
                form.Show(); 
            }
        }
    }
}
