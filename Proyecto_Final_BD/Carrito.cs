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
    public partial class Carrito : Form
    {
        public Carrito()
        {
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
            grvCarrito.DataSource = new DAOCarrito().getAll();
            grvCarrito.Columns[0].Visible = false;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            grvCarrito.Columns.Add(btn);
            btn.Text = "Eliminar";
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
                grvCarrito.Columns.Remove("ColEliminar");
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
    }
}
