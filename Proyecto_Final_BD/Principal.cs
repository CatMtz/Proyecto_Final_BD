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
                    btnAñadirProd.Visible = true;
                    pctbCarrito.Visible = false;
                    grvPrincipal.DataSource = null;
                    grvPrincipal.DataSource = new DAOProducto().getAll();

                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
                    grvPrincipal.Columns.Add(btn);
                    btn.Text = "Editar";
                    btn.Name = "ColEditar";
                    grvPrincipal.Columns.Add(btn1);
                    btn1.Text = "Eliminar";
                    btn1.Name = "ColEliminar";
                    btn.UseColumnTextForButtonValue = true;
                    btn1.UseColumnTextForButtonValue = true;
                }else if(tipo=="Cliente")
                {
                    btnRegistrar.Hide();
                    btnIniciarSesion.Hide();
                    btnCerrar.Visible = true;
                    btnAñadirProd.Visible = false;
                    pctbCarrito.Visible = true;
                    grvPrincipal.DataSource = null;
                    grvPrincipal.DataSource = new DAOProducto().getAll();
                    DataGridViewButtonColumn btnAñadir = new DataGridViewButtonColumn();
                    grvPrincipal.Columns.Add(btnAñadir);
                    btnAñadir.Text = "Añadir";
                    btnAñadir.Name = "ColAñadir";
                    btnAñadir.UseColumnTextForButtonValue = true;
                }
             

            }
            else
            {
                btnCerrar.Hide();
                btnAñadirProd.Hide();
                pctbCarrito.Visible = false;
                grvPrincipal.DataSource = null;
                grvPrincipal.DataSource = new DAOProducto().getAll();

            }
        }

        private void grvPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tipo == "Administrador")
            {
                if (e.ColumnIndex ==5)  
                {
                    int idprod=int.Parse(""+ grvPrincipal.Rows[e.RowIndex].Cells[0].Value);
                    new Editar(idprod).Show();
                    this.Hide();
                    
                }
                if (e.ColumnIndex == 6) 
                {
                  
                    new DAOProducto().delete((int)grvPrincipal.Rows[e.RowIndex].Cells[0].Value);
                    actualizarTabla();

                }
            }
            else if (tipo == "Cliente")
            {
                if (e.ColumnIndex == 4)
                {
                    int idpro= int.Parse("" + grvPrincipal.Rows[e.RowIndex].Cells[0].Value);
                    String nom =""+ grvPrincipal.Rows[e.RowIndex].Cells[1].Value;
                    int precio =int.Parse(""+grvPrincipal.Rows[e.RowIndex].Cells[2].Value);


                    Carritos car = new Carritos(idpro, nom, precio);

                    new DAOCarrito().agregar(car);
                    
                }

            }
        }
        public void actualizarTabla()
        {
            if (tipo == "Administrador")
            {
                grvPrincipal.Columns.Remove("ColEliminar");
                grvPrincipal.Columns.Remove("ColEditar");
                grvPrincipal.DataSource = null;
                grvPrincipal.DataSource = new DAOProducto().getAll();
             
            }
            else if (tipo=="Cliente")
            {
                grvPrincipal.Columns.Remove("ColAñadir");
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
            pctbCarrito.Visible = false;
            idusuario = 0;
            actualizarTabla();
           
        }

        private void pctbCarrito_Click(object sender, EventArgs e)
        {
            new Carrito().Show();
            this.Hide();
        }
    }
}
