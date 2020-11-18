using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.MODELOS
{
   public class Usuario
    {
        public int IdUsuario { get; set; }
        public String Nombre { get; set; }
        public String  Apellidos { get; set; }
        public String  UserName { get; set; }
        public String  Password { get; set; }
        public String Tipo { get; set; }

        public Usuario() { }
        /// <summary>
        /// Metodo que recibe los valores a registrar o que se necesitaran
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="ape"></param>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <param name="tipo"></param>
        public Usuario(String nom,String ape,String user,String pass,String tipo)
        {
            Nombre = nom;
            Apellidos = ape;
            UserName = user;
            Password = pass;
            Tipo = tipo;
        }

    }
}
