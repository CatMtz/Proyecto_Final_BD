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
    public partial class Principal : Form
    {
        public static int idusuario=0;
        String tipo = "";
        public Principal()
        {
            InitializeComponent();
        }
        public Principal(int id)
        {
            idusuario = id;
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

            if (idusuario != 0)
            {
               tipo= new DAOUsuario().getOne(idusuario).Tipo;
                if (tipo == "Administrador")
                {
                    btnRegistrar.Hide();
                    btnIniciarSesion.Hide();
                    btnCerrar.Visible = true;
                    grvPrincipal.DataSource = null;
                    grvPrincipal.DataSource = new DAOProducto().getAll();

                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
                    grvPrincipal.Columns.Add(btn);
                    btn.Text = "Editar";
                    grvPrincipal.Columns.Add(btn1);
                    btn1.Text = "Eliminar";
                    btn.UseColumnTextForButtonValue = true;
                    btn1.UseColumnTextForButtonValue = true;
                }else if(tipo=="Cliente")
                {
                    btnRegistrar.Hide();
                    btnIniciarSesion.Hide();
                    btnCerrar.Visible = true;
                    grvPrincipal.DataSource = null;
                    grvPrincipal.DataSource = new DAOProducto().getAll();
                }
             

            }
            else
            {
                btnCerrar.Hide();
                grvPrincipal.DataSource = null;
                grvPrincipal.DataSource = new DAOProducto().getAll();

            }
        }

        private void grvPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)  //Dónde la columna con el botón es la 6 con posición 5
            {
                //Eliminar
                /*Hacer algo ...*/
                MessageBox.Show(string.Format("Editar " + e.RowIndex));
                new Editar(idusuario).Show();
                this.Hide();
              

            }
            if (e.ColumnIndex == 5)  //Dónde la columna con el botón es la 6 con posición 5
            {
                //Editar
                /*Hacer algo ...*/
                MessageBox.Show(string.Format("Eliminar"));
                new DAOProducto().delete((int)grvPrincipal.Rows[e.RowIndex].Cells[0].Value);
                actualizarTabla();

            }
        }
        public void actualizarTabla()
        {
            if (tipo == "Administrador")
            {
                grvPrincipal.DataSource = null;
                grvPrincipal.DataSource = new DAOProducto().getAll();
                grvPrincipal.Columns.Remove("ColElimiar");
                grvPrincipal.Columns.Remove("ColEditar");
            }
            else if (tipo=="Cliente")
            {
                grvPrincipal.DataSource = null;
                grvPrincipal.DataSource = new DAOProducto().getAll();
            }
          
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            new iniciarSesion().Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            btnIniciarSesion.Show();
            btnRegistrar.Show();
            btnCerrar.Hide();
            idusuario = 0;
            actualizarTabla();
           
        }
    }
}
