using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BackEnd.MODELOS;
using MySql.Data.MySqlClient;

namespace BackEnd.DAOS
{
    public class DaoDetalleProducto
    {
        /// <summary>
        /// Utilizaremos el metodo agregar para cada vez que el usuario agregue un producto al carrito desde la 
        /// pagina principal
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int agregar(DetalleProducto m, String nom, int idusu)
        {
            MySqlConnection conexion = null;
            int afectados = 0;
            try
            {
                conexion = new MySqlConnection(new ConexionMySQL().GetConnectionString());
                conexion.Open();
                String consulta = "INSERT INTO detalleproducto "
                    + "VALUES ((select c.idcarrito from carrito c" +
                    " where NombreProd='" + nom + "' and idUsuario='" + idusu + "' group by idUsuario)," +
                    "@idProducto,@Precio,@Cantidad)";
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = consulta;
                comando.CommandType = System.Data.CommandType.Text;
                comando.Parameters.AddWithValue("@IdCarrio", m.Precio);
                comando.Parameters.AddWithValue("@idProducto", m.idProducto);
                comando.Parameters.AddWithValue("@Precio", m.Precio);
                comando.Parameters.AddWithValue("@Cantidad", m.cantidad);
                afectados = comando.ExecuteNonQuery();

                return afectados;

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudieron registrar los detalles del producto");

            }
            finally
            {
                if (afectados != 0)
                {
                    conexion.Close();
                }
            }
        }

              /// <summary>
              /// Usaremos el metodo de eliminar para poder quitar elementos de nuestro carrito
              /// </summary>
              /// <param name="id"></param>
              /// <returns></returns>
        public bool delete()
        {
            ConexionMySQL conexion = new ConexionMySQL();
            try
            {
                String SQL = "DELETE FROM detalleproducto;";
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
