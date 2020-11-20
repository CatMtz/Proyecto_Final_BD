using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd.MODELOS;
using BackEnd.DAOS;

namespace Proyecto_Final_BD
{
    public partial class AñadirProducto : Form
    {
        public AñadirProducto()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtPrecio.Text != "" && txtDescripcion.Text != "" && txtCategoria.Text != "")
            {
                Producto produc = new Producto(txtNombre.Text, int.Parse(txtPrecio.Text), txtDescripcion.Text, txtCategoria.Text);
                new DAOProducto().registrar(produc);
                txtNombre.Text = "";
                txtPrecio.Text = "";
                txtDescripcion.Text = "";
                txtCategoria.Text = "";
            }
            else
            {
                MessageBox.Show("Verifique que todos los espacios esten llenos");
            }
            
        }
    }
}
