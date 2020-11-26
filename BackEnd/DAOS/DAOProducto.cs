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
                    datos.Nombre = (String)r.ItemArray[1];
                    datos.Precio = (Decimal)r.ItemArray[2];
                    datos.Descripcion = (String)r.ItemArray[3];
                    datos.Categoria = (String)r.ItemArray[4];


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
        /// Obtenemos un solo producto ya que sera necesario para poder editar nuestro producto
        /// </summary>
        /// <param name="Idproducto"></param>
        /// <returns></returns>
        public Producto getOne(int Idproducto)
        {
            MySqlConnection conexion = null;
            try
            {
                conexion = new MySqlConnection(new ConexionMySQL().GetConnectionString());
                conexion.Open();
                String consulta = "SELECT * FROM producto WHERE idProducto='" + Idproducto + "';";
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = consulta;
                MySqlDataReader lector = comando.ExecuteReader();
                Producto obtenerdatosusuario;
                if (lector.Read())
                {
                    obtenerdatosusuario = new Producto();
                    obtenerdatosusuario.IdProducto = lector.GetInt32("IdProducto");
                    obtenerdatosusuario.Nombre = lector.GetString("Nombre");
                    obtenerdatosusuario.Precio = lector.GetInt32("Precio");
                    obtenerdatosusuario.Descripcion = lector.GetString("Descripcion");
                    obtenerdatosusuario.Categoria = lector.GetString("Categoria");


                    return obtenerdatosusuario;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al autenticar");
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }
        }
        /// <summary>
        /// Se registra un nuevo Producto
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool registrar(Producto obj)
        {
            MySqlConnection conexion = null;
            try
            {
                conexion = new MySqlConnection(new ConexionMySQL().GetConnectionString());
                conexion.Open();
                String consulta = "INSERT INTO Producto "
                    + "VALUES (default, @Nombre, @Precio, @Descripcion)" + ";";
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
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }

        }
        /// <summary>
        /// Metodo utilizado para eliminar un producto de la lista
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
                throw new Exception("No se pudo eliminar el Producto");
            }
        }

        /// <summary>
        /// REcibe los datos de la interfaz "Editar" y asi modificarlos directamente en nuestra base de datos
        /// </summary>
        /// <param name="prod"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Actualizar(Producto prod, int id)
        {
            MySqlConnection conexion = null;
            try
            {
                conexion = new MySqlConnection(new ConexionMySQL().GetConnectionString());
                conexion.Open();
                string consulta = "update Producto SET `IdProducto` =@ID, `Nombre` =@Nombre,`Precio` = @Precio,`Descripcion` = @Descripcion,`Categoria` = @Categoria" +
                    " Where IdProducto='" + id + "';";
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = consulta;
                comando.CommandType = System.Data.CommandType.Text;
                comando.Parameters.AddWithValue("@ID", id);
                comando.Parameters.AddWithValue("@Nombre", prod.Nombre);
                comando.Parameters.AddWithValue("@Precio", prod.Precio);
                comando.Parameters.AddWithValue("@Descripcion", prod.Descripcion);
                comando.Parameters.AddWithValue("@Categoria", prod.Categoria);
                int afectados = comando.ExecuteNonQuery();
                return afectados;
            }
            catch (Exception ex)
            {

                throw new Exception("No se pudo hacer la actualización de la informacion");
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }

        }
    }
}