using BackEnd.MODELOS;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace BackEnd.DAOS
{
    public class DAOUsuario
    {
        /// <summary>
        /// Obtenemos una lista de todos los usuarios en caso de requerirla
        /// </summary>
        /// <returns></returns>
        public List<Usuario> getAll()
        {
            try
            {
                List<Usuario> lista = new List<Usuario>();
                ConexionMySQL con = new ConexionMySQL();

                DataSet dat = con.LLenaComboGrid("SELECT * FROM Usuario" + ";");
                DataTable dt = dat.Tables[0];
                Usuario datos;
                foreach (DataRow r in dt.Rows)
                {
                    datos = new Usuario();
                    datos.IdUsuario = (int)r.ItemArray[0];
                    datos.Nombre = (String)r.ItemArray[1];
                    datos.Password = (String)r.ItemArray[2];


                    lista.Add(datos);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos del usuario");
            }
           
        }
       /// <summary>
       /// Se registra un nuevo usuario
       /// </summary>
       /// <param name="obj"></param>
       /// <returns></returns>
        public bool registrar(Usuario obj)
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(new ConexionMySQL().GetConnectionString());
                conexion.Open();
                String consulta = "INSERT INTO Usuario "
                    + "VALUES (default,@Nombre, @Apellido, @Username, Sha1(@Password), @Tipo)"+";";
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = consulta;
                comando.CommandType = System.Data.CommandType.Text;
                comando.Parameters.AddWithValue("@Nombre", obj.Nombre);
                comando.Parameters.AddWithValue("@Apellido", obj.Apellidos);
                comando.Parameters.AddWithValue("@Username", obj.UserName);
                comando.Parameters.AddWithValue("@Contraseña", obj.Password);
                comando.Parameters.AddWithValue("@Tipo", obj.Tipo);
                int regafectados = comando.ExecuteNonQuery();
                conexion.Close();
                return (regafectados > 0);

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo hacer el registro del usuario");
            }
           
        }
        /// <summary>
        /// Verificar si el usuario esta registrado (LOGIN)
        /// </summary>
        /// <param name="username"></param>
        /// <param name="contraseña"></param>
        /// <returns></returns>
        public Usuario Verificarusuario(string username, string contraseña)
        {
            MySqlConnection conexion = null;
            try
            {
                conexion = new MySqlConnection(new ConexionMySQL().GetConnectionString());
                conexion.Open();
                String consulta = "SELECT *  FROM Usuario WHERE Username = @Username AND password = Sha1(@Password)"+";";
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = consulta;
              
                comando.Parameters.AddWithValue("@Username", username);
                comando.Parameters.AddWithValue("@Password", contraseña);
                MySqlDataReader lector = comando.ExecuteReader();
                Usuario obtenerdatosusuario;
                if (lector.Read())
                {
                    obtenerdatosusuario = new Usuario();
                    obtenerdatosusuario.IdUsuario = lector.GetInt32("IdUsuario");
                    obtenerdatosusuario.Nombre = lector.GetString("Nombre");
                    obtenerdatosusuario.Apellidos = lector.GetString("Apellido");
                    obtenerdatosusuario.UserName = lector.GetString("Username");
                    obtenerdatosusuario.Password = lector.GetString("Password");
                    obtenerdatosusuario.Tipo = lector.GetString("Tipo");
                    
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
    }
}