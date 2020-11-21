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
using BackEnd.MODELOS;
using System.Text.RegularExpressions;

namespace Proyecto_Final_BD
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            new Principal().Show();
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
            if (txtApellido.Text == "Apellidos")
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
                txtApellido.Text = "Apellidos";
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

     
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DAOUsuario usu = new DAOUsuario();
           
            if(txtNombre.Text!="Nombre"&& txtApellido.Text != "Apellidos" && txtUsername.Text != "Username" &&
                txtContraseña.Text != "Contraseña" && txtConfirmar.Text != "Confirmar Contraseña")
            {
                if (verificarContraseña(txtContraseña.Text))
                {
                    if (txtContraseña.Text == txtConfirmar.Text)
                    {
                        Usuario nuevo = new Usuario(txtNombre.Text, txtApellido.Text, txtUsername.Text,
                       txtContraseña.Text,"Cliente");
                        usu.registrar(nuevo);

                        txtNombre.Text = "registro";
                        txtApellido.Text = "Apellidos";
                        txtUsername.Text = "UserName";
                        txtContraseña.Text = "Contraseña";
                        txtConfirmar.Text = "Confirmar Contraseña";
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
        public bool verificarContraseña(String pass)
        {

            string expresion= @"^(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8}$";
            Regex automata =new Regex(expresion);

            bool resultado = automata.IsMatch(pass);
            return resultado;
        }
    }
}
