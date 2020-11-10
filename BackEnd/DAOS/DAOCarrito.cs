using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using BackEnd.MODELOS;
using System.Data;


namespace BackEnd.DAOS
{
    public class DAOCarrito
    {

        public bool delete(int id)
        {
            ConexionMySQL conexion = new ConexionMySQL();
            try
            {
                String SQL = "DELETE FROM carrito WHERE" + " idCarrito= '" + id + "';";
                MySqlCommand sqlcom = new MySqlCommand();
                sqlcom.CommandText = SQL;
                conexion.EjecutaSQLComando(sqlcom);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Carrito> getOne(String id)
        {
            try
            {
                List<Carrito> lista = new List<Carrito>();
                ConexionMySQL con = new ConexionMySQL();

                DataSet dat = con.LLenaComboGrid("SELECT * FROM carrito where idusuario =" + id + ";");
                DataTable dt = dat.Tables[0];
                Carrito datos;
                foreach (DataRow r in dt.Rows)
                {
                    datos = new Carrito();
                    datos.idCarrito = (int)r.ItemArray[0];
                    datos.idProducto = (int)r.ItemArray[1];
                    datos.NombreProducto = (String)r.ItemArray[2];
                    datos.Precio = (double)r.ItemArray[3];
                    datos.Cantidad = (int)r.ItemArray[4];

                    lista.Add(datos);
                }
                return lista;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


    }

}
