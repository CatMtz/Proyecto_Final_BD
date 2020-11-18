using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd.DAOS;


namespace Proyecto_Final_BD
{
    public partial class iniciarSesion : Form
    {
        public int idusu=0;
        public iniciarSesion()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            new Principal().Show();
            this.Dispose();
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Username...")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.LightGray;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Username...";
                txtNombre.ForeColor = Color.Silver;
            }
        }

      
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password...")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password...";
                txtPassword.ForeColor = Color.Silver;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            DAOUsuario usu = new DAOUsuario();

          if(usu.Verificarusuario(txtNombre.Text, txtPassword.Text)!=null)
            {
               new Principal( idusu = usu.Verificarusuario(txtNombre.Text, txtPassword.Text).IdUsuario);
                Principal menu = new Principal();
                menu.Show();
                this.Hide();
            }
          else
            {
                MessageBox.Show("Usuario y/o Contraseña incorrectos");
                   txtNombre.Text = "Username...";
                   txtPassword.Text = "Password...";
            }

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Registro reg = new Registro();
            reg.Show();
            this.Close();
        }
    }
}
