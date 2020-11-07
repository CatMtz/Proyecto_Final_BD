using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea3_3.DAOS;
using Tarea3_3.Modelos;

namespace Tarea3_3
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            Principal pri = new Principal();
            pri.Show();
            this.Dispose();
        }


        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Silver;
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellido")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.Silver;
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Silver;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Silver;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Silver;
            }
        }

        private void txtConfirmar_Enter(object sender, EventArgs e)
        {
            if (txtConfirmar.Text == "Confirmar Contraseña")
            {
                txtConfirmar.Text = "";
                txtConfirmar.ForeColor = Color.Silver;
            }
        }

        private void txtDescripcion_Enter(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "Descripcion (Opcional)")
            {
                txtDescripcion.Text = "";
                txtDescripcion.ForeColor = Color.Silver;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.Silver;
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Apellido";
                txtApellido.ForeColor = Color.Silver;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Silver;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Silver;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.Silver;
            }
        }

        private void txtConfirmar_Leave(object sender, EventArgs e)
        {
            if (txtConfirmar.Text == "")
            {
                txtConfirmar.Text = "Confirmar Contraseña";
                txtConfirmar.ForeColor = Color.Silver;
            }
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                txtDescripcion.Text = "Descripcion (Opcional)";
                txtDescripcion.ForeColor = Color.Silver;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DAOUsuario usu = new DAOUsuario();
           
            if(txtNombre.Text!="Nombre"&& txtApellido.Text != "Apellido" && txtUsername.Text != "Username" &&
                txtEmail.Text != "Email" && txtContraseña.Text != "Contaseña" && txtConfirmar.Text != "Confirmar Contraseña")
            {
                if (txtContraseña.Text.Length>2 && txtContraseña.Text.Length <= 5)
                {
                    if (txtContraseña.Text == txtConfirmar.Text)
                    {
                        Usuario nuevo = new Usuario(txtNombre.Text, txtApellido.Text, txtUsername.Text,
                      txtEmail.Text, txtContraseña.Text, txtDescripcion.Text);
                        usu.registrar(nuevo);
                        txtNombre.Text = "";
                        txtApellido.Text = "";
                        txtUsername.Text = "";
                        txtEmail.Text = "";
                        txtContraseña.Text = "";
                        txtConfirmar.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden");
                    }
                }else
                {
                    MessageBox.Show("La contraseña debe ser entre 2 y 5 caracteres");
                }
               
              
            }
            else
            {
                MessageBox.Show("Alguno de los espacios esta en blanco, favor de verificar");
            }
        }
    }
}
