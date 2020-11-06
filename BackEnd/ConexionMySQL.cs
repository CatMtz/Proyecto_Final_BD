using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;

namespace Tarea3_3
{
 
        public  class ConexionMySQL
        {
        /// <summary>
        /// Se realiza la conexion a nuestra base de datos 
        /// </summary>
        /// <returns></returns>
            public  string GetConnectionString()
            {
    
             
                String servidor = "localhost";
                String puerto = "3306";
                String usuario = "root";
                String password = "root";
                String database = "ProyectoBD";
                //Cadena de conexion

                return String.Format("server={0};port={1};user id={2}; password={3}; database={4}", servidor, puerto, usuario, password, database);
            }
            /// <summary>
            /// Este metodo se manda llamar en las consultas que se 
            /// realizaran o en los comandos de modificación para ejecutar la sentencia
            /// </summary>
            /// <param name="sqlCom"></param>
            public  void EjecutaSQLComando(MySqlCommand sqlCom)
            {
                MySqlConnection sqlConn = new MySqlConnection();
                //MySqlCommand sqlCom = new MySqlCommand();
                try
                {
                    sqlConn.ConnectionString = GetConnectionString();
                    sqlConn.Open();
                    sqlCom.Connection = sqlConn;
                    //sqlCom.CommandText = sComandoSql;
                    sqlCom.ExecuteNonQuery();
                }catch (Exception e){

                }
                finally
                {
                    sqlConn.Close();
                }
            }
        /// <summary>
        /// Este método se utiliza más para las consultas que devolveran
        /// más de un registro de la base de datos y se colocaran en una tabla
        /// y recibe la consulta 
        /// </summary>
        /// <param name="mysql"></param>
        /// <returns></returns>
            public DataSet LLenaComboGrid(string mysql)
            {
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlConnection cnn = new MySqlConnection();
                MySqlCommand cmd = new MySqlCommand();
                try
                {
                    cnn.ConnectionString = GetConnectionString();
                    cnn.Open();
                    cmd.CommandText = mysql;
                    da.SelectCommand = cmd;
                    da.SelectCommand.Connection = cnn;
                    da.Fill(ds);
                }catch(Exception e)
            {

            }
                finally
                {

                    cnn.Close();
                }
                return ds;
            }
        /// <summary>
        /// Este metodo hace lo mismo que el de arriba solo 
        /// que en este recibe la sentencia pero como un comando de mysqlCommand
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
            public DataSet LLenaComboGrid(MySqlCommand cmd)
            {
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlConnection cnn = new MySqlConnection();
                try
                {
                    cnn.ConnectionString = GetConnectionString();
                    cnn.Open();
                    //cmd.CommandText = mysql;
                    da.SelectCommand = cmd;
                    da.SelectCommand.Connection = cnn;
                    da.Fill(ds);
                }
            catch (Exception e)
            {

            }
            finally
                {

                    cnn.Close();
                }
                return ds;
            }
        }
}