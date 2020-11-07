using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.MODELOS
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public String Nombre { get; set; }
        public String  Telefono { get; set; }
        public String Localidad { get; set; }

        public Proveedor() { }

        public Proveedor(String nom,String tel,String loc)
        {
            Nombre = nom;
            Telefono = tel;
            Localidad = loc;
        }

    }
}
