using BackEnd.MODELOS;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace BackEnd.DAOS
{
    public class DAOProveedor
    {
        /// <summary>
        /// Obtenemos una lista de todos los Proveedores en caso de requerirla
        /// </summary>
        /// <returns></returns>
        public List<Proveedor> getAll()
        {
            try
            {
                List<Proveedor> lista = new List<Proveedor>();
                ConexionMySQL con = new ConexionMySQL();

                DataSet dat = con.LLenaComboGrid("SELECT * FROM Proveedor" + ";");
                DataTable dt = dat.Tables[0];
                Proveedor datos;
                foreach (DataRow r in dt.Rows)
                {
                    datos = new Proveedor();
                    datos.IdProveedor = (int)r.ItemArray[0];
                    datos.Nombre = (String)r.ItemArray[1];
                    datos.Telefono = (String)r.ItemArray[2];
                    datos.Localidad = (String)r.ItemArray[3];


                    lista.Add(datos);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos del Proveedor");
            }
           
        }
       /// <summary>
       /// Se registra un nuevo Proveedor
       /// </summary>
       /// <param name="obj"></param>
       /// <returns></returns>
        public bool registrar(Proveedor obj)
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(new ConexionMySQL().GetConnectionString());
                conexion.Open();
                String consulta = "INSERT INTO Proveedor "
                    + "VALUES (default,@Nombre, @Telefono, @localidad"+";";
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = consulta;
                comando.CommandType = System.Data.CommandType.Text;
                comando.Parameters.AddWithValue("@Nombre", obj.Nombre);
                comando.Parameters.AddWithValue("@Telefono", obj.Telefono);
                comando.Parameters.AddWithValue("@Localidad", obj.Localidad);
                int regafectados = comando.ExecuteNonQuery();
                conexion.Close();
                return (regafectados > 0);

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo hacer el registro del Proveedor");
            }
           
        }
        
    }
}