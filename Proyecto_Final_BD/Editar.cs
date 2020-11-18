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

namespace Proyecto_Final_BD
{
    public partial class Editar : Form
    {
        public static int idusuario = 0;
        public Editar()
        {
            InitializeComponent();
        }
        public Editar(int id)
        {
            idusuario = id;
        }

        private void Editar_Load(object sender, EventArgs e)
        {
           Producto prod= new DAOProducto().getOne(idusuario);
            txtNombre.Text = prod.Nombre;
            txtPrecio.Text =""+ prod.Precio;
            txtDescripcion.Text = prod.Descripcion;
            txtCategoria.Text = prod.Categoria;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Producto produc = new Producto(txtNombre.Text, int.Parse( txtPrecio.Text), txtDescripcion.Text, txtCategoria.Text);
            if (new DAOProducto().Actualizar(produc, idusuario) == 1)
            {
                MessageBox.Show("Los Datos se actualizaron con exito");
            }
          
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            new Principal().Show();
            this.Dispose();
        }
    }
}
