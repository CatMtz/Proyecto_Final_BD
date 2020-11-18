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
        /// <summary>
        /// Obtenemos una lista de todos lo que hay en carrito para su respectiva interfaz
        /// </summary>
        /// <returns></returns>
        public List<Carritos> getAll()
        {
            try
            {
                List<Carritos> lista = new List<Carritos>();
                ConexionMySQL con = new ConexionMySQL();

                DataSet dat = con.LLenaComboGrid("SELECT * FROM Carrito" + ";");
                DataTable dt = dat.Tables[0];
                Carritos datos;
                foreach (DataRow r in dt.Rows)
                {
                    datos = new Carritos();
                    datos.idCarrito = (int)r.ItemArray[0];
                    datos.idProducto = (int)r.ItemArray[1];
                    datos.NombreProducto = (String)r.ItemArray[2];
                    datos.Precio = (int)r.ItemArray[3];
                


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
        /// Usaremos el metodo de eliminar para poder quitar elementos de nuestro carrito
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        public Carritos getOne(String id)
        {
            MySqlConnection conexion = null;
            try
            {
                conexion = new MySqlConnection(new ConexionMySQL().GetConnectionString());
                conexion.Open();
                String consulta = "SELECT * FROM Carrito WHERE idcarrito='" + id + "';";
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = consulta;
                MySqlDataReader lector = comando.ExecuteReader();
                Carritos obtenerdatosusuario;
                if (lector.Read())
                {
                    obtenerdatosusuario = new Carritos();
                    obtenerdatosusuario.idCarrito = lector.GetInt32("idCarrito");
                    obtenerdatosusuario.idProducto = lector.GetInt32("idProducto");
                    obtenerdatosusuario.NombreProducto = lector.GetString("NombreProd");
                    obtenerdatosusuario.Precio = lector.GetInt32("Precio");



                    return obtenerdatosusuario;
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }
        }


        public int agregar(Carritos m)
        {
            MySqlConnection conexion = null;
            int afectados = 0;
            try
            {
                 conexion = new MySqlConnection(new ConexionMySQL().GetConnectionString());
                conexion.Open();
                String consulta = "INSERT INTO carrito "
                    + "VALUES (default,@IdProducto,@Nombreproducto, @Precio)";
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = consulta;
                comando.CommandType = System.Data.CommandType.Text;
                comando.Parameters.AddWithValue("@Nombreproducto", m.NombreProducto);
                comando.Parameters.AddWithValue("@Precio", m.Precio);
                comando.Parameters.AddWithValue("@IdProducto", m.idProducto);
                afectados = comando.ExecuteNonQuery();
               
                return afectados;

            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                if (afectados != 0)
                {
                    conexion.Close();
                }
            }

        }

    }

}
