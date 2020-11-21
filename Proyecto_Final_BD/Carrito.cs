using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BackEnd.DAOS;
using System.IO;
using BackEnd.MODELOS;

namespace Proyecto_Final_BD
{
    public partial class Carrito : Form
    {
        int idusuario = 0;
        public Carrito()
        {
            InitializeComponent();
        }
        public Carrito(int id)
        {
            idusuario = id;
            InitializeComponent();
            
        }

        /// <summary>
        /// En el metodo loda cargaremos todos los datos que existan dentro del
        /// carrito y asi mismo añadimos el catalogo de botones para su edición
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Carrito_Load(object sender, EventArgs e)
        {
            
            grvCarrito.DataSource = null;
            grvCarrito.DataSource = traer(idusuario);
            grvCarrito.Columns[0].Visible = false;
            grvCarrito.Columns[1].Visible = false;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            grvCarrito.Columns.Add(btn);
            btn.Text = "Eliminar";
            btn.Name = "Eliminar";
            btn.UseColumnTextForButtonValue = true;
         

        }
        /// <summary>
        /// Usamos el evento cellcontentclick para saber que haremos cuando se de click en el boton creado dinamicamente
        /// y cone sto mandar llamar su respectivo metodo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grvCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)  //Dónde la columna con el botón es la 6 con posición 5
            {
                //Eliminar
                /*Hacer algo ...*/
                MessageBox.Show(string.Format("Elimiar " +e.RowIndex));
                new DAOProducto().delete((int)grvCarrito.Rows[e.RowIndex].Cells[0].Value);
                grvCarrito.Columns.Remove("Eliminar");
                actualizarTabla();

            }
           
        }
        public void actualizarTabla()
        {
            grvCarrito.DataSource = null;
            grvCarrito.DataSource = new DAOProducto().getAll();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            grvCarrito.Columns.Add(btn);
            btn.Text = "Eliminar";
            btn.UseColumnTextForButtonValue = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            new Principal().Show();
            this.Dispose();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(@"C:\Users\micue\Documents\Visual Studio 2015\Projects\Proyecto_Final_BD\Proyecto_Final_BD\Notas.txt", true);
            try
            {
                writer.Write("\n\n\n");
                for (int i = 0; i < grvCarrito.Rows.Count; i++)
                {
                    writer.WriteLine("---------------------------------------------------------------------------------------");
                    for (int j = 0; j < grvCarrito.Columns.Count-1; j++)
                    {
                        writer.Write("\t" +grvCarrito.Columns[j].Name+": "+ grvCarrito.Rows[i].Cells[j].Value + "\t" + "|");
                    }
                    writer.WriteLine("");
                    writer.WriteLine("---------------------------------------------------------------------------------------");
                }
                
                writer.Write(new DAOUsuario().getOne(idusuario).Nombre+" "+ new DAOUsuario().getOne(idusuario).Apellidos + "\t\t\t\t" + lblTotal.Text);
                bool borrar = new DAOCarrito().deleteAll(idusuario);
                MessageBox.Show("Se realizo la compra con exito");
                new Principal().Show();
                this.Dispose();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                writer.Close();
            }
        }
        protected List<Carritos> traer(int id)
        {

            decimal total = 0;
          
            List<Carritos> lista = new DAOCarrito().getOne(id);
            
            Carritos[] list = new Carritos[lista.Count];
            Carritos inf;

            for (int i = 0; i < lista.Count; i++)
            {
                inf = new Carritos();
                total += lista[i].Total;
            }
          
            lblTotal.Text = "Total: $" + total;
            return lista;
        }
    }
}
