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
    }
}
