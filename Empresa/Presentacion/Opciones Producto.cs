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
            if (cbOpciones.SelectedItem is Opciones opcionSeleccionada)
            {
                txtEditar.Text = opcionSeleccionada.Nombre;
            }
        }

        private void btnAgregarOp_Click(object sender, EventArgs e)
        {
            string nuevaOpcion = txtAgregarOpcion.Text.Trim();

            if (string.IsNullOrWhiteSpace(nuevaOpcion))
            {
                MessageBox.Show("Debe ingresar una opción válida.");
                return;
            }

            CN_Opcion datos = new CN_Opcion(); // <- asegurate de tener esto

            // Validar duplicado
            var existentes = datos.Listar()
                .Where(o => o.idNombreProducto == _idProducto)
                .ToList();

            bool yaExiste = existentes.Any(o => o.Nombre.Equals(nuevaOpcion, StringComparison.OrdinalIgnoreCase));
            if (yaExiste)
            {
                MessageBox.Show("Esta opción ya existe.");
                return;
            }

            // Insertar
            Opciones nuevaOpcionInsertada = datos.Crear(nuevaOpcion, _idProducto);

            if (nuevaOpcionInsertada != null)
            {
                MessageBox.Show("Opción agregada correctamente.");
                txtAgregarOpcion.Clear();
                CargarOpcionesProducto();

                // Seleccionarla automáticamente
                cbOpciones.SelectedValue = nuevaOpcionInsertada.idOpcion;
            }
            else
            {
                MessageBox.Show("Error al agregar la opción.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verificamos que haya una opción seleccionada
            if (cbOpciones.SelectedItem is Opciones opcionSeleccionada)
            {
                string nuevoNombre = txtEditar.Text.Trim();

                // Validación básica
                if (string.IsNullOrWhiteSpace(nuevoNombre))
                {
                    MessageBox.Show("Debe ingresar un nombre válido para la opción.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar que no exista otra opción con ese nombre
                CN_Opcion logica = new CN_Opcion();
                var otrasOpciones = logica.Listar()
                    .Where(o => o.idNombreProducto == _idProducto && o.idOpcion != opcionSeleccionada.idOpcion)
                    .ToList();

                bool yaExiste = otrasOpciones.Any(o => o.Nombre.Equals(nuevoNombre, StringComparison.OrdinalIgnoreCase));
                if (yaExiste)
                {
                    MessageBox.Show("Ya existe otra opción con ese nombre para este producto.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ejecutar la edición
                Opciones resultado = logica.Editar(opcionSeleccionada.idOpcion, nuevoNombre);

                if (resultado != null)
                {
                    MessageBox.Show("Opción editada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarOpcionesProducto(); // Refrescar el ComboBox
                    cbOpciones.SelectedValue = resultado.idOpcion; // Seleccionar de nuevo
                }
                else
                {
                    MessageBox.Show("Error al editar la opción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una opción para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
