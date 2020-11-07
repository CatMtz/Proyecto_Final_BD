using BackEnd.MODELOS;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Tarea3_3.DAOS
{
    public class DAONota
    {
        /// <summary>
        /// Obtenemos una lista de todas las Notas en caso de requerirla
        /// </summary>
        /// <returns></returns>
        public List<Nota> getAll(int id)
        {
            try
            {
                List<Nota> lista = new List<Nota>();
                ConexionMySQL con = new ConexionMySQL();

                DataSet dat = con.LLenaComboGrid("SELECT * FROM Nota where Idusuario=" +id+ ";");
                DataTable dt = dat.Tables[0];
                Nota datos;
                foreach (DataRow r in dt.Rows)
                {
                    datos = new Nota();
                    datos.IdNota = (int)r.ItemArray[0];
                    datos.Descripcion = (String)r.ItemArray[1];
                  

                    lista.Add(datos);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos del Nota");
            }
           
        }
       /// <summary>
       /// Se registra una nueva Nota
       /// </summary>
       /// <param name="obj"></param>
       /// <returns></returns>
        public bool registrar(Nota obj)
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(new ConexionMySQL().GetConnectionString());
                conexion.Open();
                String consulta = "INSERT INTO Nota "
                    + "VALUES (default,@Idusuario, @Descripcion"+";";
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = consulta;
                comando.CommandType = System.Data.CommandType.Text;
                comando.Parameters.AddWithValue("@Idusuario", obj.IdUsuario);
                comando.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                int regafectados = comando.ExecuteNonQuery();
                conexion.Close();
                return (regafectados > 0);

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo hacer el registro del Nota");
            }
           
        }
     
    }
}