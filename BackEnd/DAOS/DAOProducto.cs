using BackEnd.MODELOS;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace BackEnd.DAOS
{
    public class DAOProducto
    {
        /// <summary>
        /// Obtenemos una lista de todos los Productos en caso de requerirla
        /// </summary>
        /// <returns></returns>
        public List<Producto> getAll()
        {
            try
            {
                List<Producto> lista = new List<Producto>();
                ConexionMySQL con = new ConexionMySQL();

                DataSet dat = con.LLenaComboGrid("SELECT * FROM Producto" + ";");
                DataTable dt = dat.Tables[0];
                Producto datos;
                foreach (DataRow r in dt.Rows)
                {
                    datos = new Producto();
                    datos.IdProducto = (int)r.ItemArray[0];
                    datos.IdProveedor = (int)r.ItemArray[1];
                    datos.Nombre = (String)r.ItemArray[2];
                    datos.Precio = (int)r.ItemArray[3];
                    datos.Descripcion = (String)r.ItemArray[4];


                    lista.Add(datos);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos del Producto");
            }
           
        }
       /// <summary>
       /// Se registra un nuevo Producto
       /// </summary>
       /// <param name="obj"></param>
       /// <returns></returns>
        public bool registrar(Producto obj)
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(new ConexionMySQL().GetConnectionString());
                conexion.Open();
                String consulta = "INSERT INTO Producto "
                    + "VALUES (default,@IdProveedor, @Nombre, @Precio, @Descripcion)"+";";
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = consulta;
                comando.CommandType = System.Data.CommandType.Text;
                comando.Parameters.AddWithValue("@Nombre", obj.Nombre);
                comando.Parameters.AddWithValue("@Precio", obj.Precio);
                comando.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                int regafectados = comando.ExecuteNonQuery();
                conexion.Close();
                return (regafectados > 0);

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo hacer el registro del Producto");
            }
           
        }

        public bool delete(int id)
        {
            ConexionMySQL conexion = new ConexionMySQL();
            try
            {
                String SQL = "DELETE FROM Producto WHERE" + " idProducto= '" + id + "';";
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

    }
}