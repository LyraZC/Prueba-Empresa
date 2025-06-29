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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            /*Utilizando el metodo comparamos los valores del textbox para ver si coinciden con alguno en la lista*/

            Usuario usuario = new CN_Usuario().Listar().Where(u => u.NombreUsuario == txtCorreo.Text && u.Contraseña == txtContraseña.Text).FirstOrDefault();
            

            if(usuario != null)
            {
                Inicio form = new Inicio(usuario);
                form.Show();
                this.Hide();

                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("No se encontro al usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtCorreo.Clear();
            txtContraseña.Clear();

            this.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Crear_Usuario form = new Crear_Usuario();
            form.Show();
            this.Hide();

            form.FormClosing += frm_closing;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
