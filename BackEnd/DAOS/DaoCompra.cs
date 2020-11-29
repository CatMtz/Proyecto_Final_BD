using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.MODELOS;
using BackEnd.DAOS;
using MySql.Data.MySqlClient;
using System.Data;

namespace BackEnd.DAOS
{
    public class DaoCompra
    {
        /// <summary>
        /// Obtenemos una lista de todos los Productos en caso de requerirla
        /// </summary>
        /// <returns></returns>
        public List<Compra> getAll()
        {
            try
            {
                List<Compra> lista = new List<Compra>();
                ConexionMySQL con = new ConexionMySQL();

                DataSet dat = con.LLenaComboGrid("SELECT * FROM Compra" + ";");
                DataTable dt = dat.Tables[0];
                Compra datos;
                foreach (DataRow r in dt.Rows)
                {
                    datos = new Compra();
                    datos.idCompra = (int)r.ItemArray[0];
                    datos.idUsuario = (int)r.ItemArray[1];
                    datos.Descripcion = (String)r.ItemArray[2];
                   

                    lista.Add(datos);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos de las compras");
            }

        }
        public int agregar(Compra m)
        {
            MySqlConnection conexion = null;
            int afectados = 0;
            try
            {
                conexion = new MySqlConnection(new ConexionMySQL().GetConnectionString());
                conexion.Open();
                String consulta = "INSERT INTO Compra "
                    + "VALUES (default,@idUsuario,@NombreUsuario,@Descripcion,@CantidadVenta)";
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = consulta;
                comando.CommandType = System.Data.CommandType.Text;
                comando.Parameters.AddWithValue("@idUsuario", m.idUsuario);
                comando.Parameters.AddWithValue("@Nombreusuario", m.NombreUsuario);
                comando.Parameters.AddWithValue("@Descripcion", m.Descripcion);
                comando.Parameters.AddWithValue("@CantidadVenta", m.CantidadVenta);

                afectados = comando.ExecuteNonQuery();

                return afectados;

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo registrar el producto en carrito");
              
            }
            finally
            {
                if (afectados != 0)
                {
                    conexion.Close();
                }
            }

        }

       
        public Compra getOne(int id)
        {
            MySqlConnection conexion = null;
            try
            {
                conexion = new MySqlConnection(new ConexionMySQL().GetConnectionString());
                conexion.Open();
                String consulta = "SELECT * FROM Compra WHERE idusuario='" + id + "';";
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = consulta;
                MySqlDataReader lector = comando.ExecuteReader();
                Compra obtenerdatos;
                if (lector.Read())
                {
                    obtenerdatos = new Compra();
                    obtenerdatos.idCompra = lector.GetInt32("idCompra");
                    obtenerdatos.idUsuario = lector.GetInt32("Idusuario");
                    obtenerdatos.Descripcion = lector.GetString("Descripcion");
                


                    return obtenerdatos;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos de compra");
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }
        }

    }
}
