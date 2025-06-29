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
using System.Text.RegularExpressions;

namespace Presentacion
{
    public partial class Crear_Usuario : Form
    {
        public Crear_Usuario()
        {
            InitializeComponent();
        }

        private void btnCancelar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim();
            string telefono = txtTelefono.Text.Trim();

            // Validar correo con estructura nombre@dominio.com
            if (!Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El correo no tiene un formato válido (ej: juan@gmail.com).");
                return;
            }

            // Validar teléfono con estructura 0000-0000
            if (!Regex.IsMatch(telefono, @"^\d{4}-\d{4}$"))
            {
                MessageBox.Show("El teléfono debe tener el formato 0000-0000.");
                return;
            }

            CN_Usuario usuario = new CN_Usuario();

            Usuario nuevo = new Usuario()
            {
                NombreUsuario = txtNombreUsuario.Text,
                Contraseña = txtContraseña.Text,
                Nombre = txtNombres.Text,
                Apellido = txtApellidos.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text,
                
            };

            Usuario resultado = usuario.Crear(nuevo);

            if (resultado != null )
            {
                MessageBox.Show("Usuario creado");
            }
            else
            {
                MessageBox.Show("Error al crear el usuario.");
            }

            txtNombreUsuario.Clear();
            txtContraseña.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();

        }

        private void Crear_Usuario_Load(object sender, EventArgs e)
        {

        }
    }
}
