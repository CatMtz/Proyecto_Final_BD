using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.MODELOS
{
   public class Producto
    {
        public int IdProducto { get; set; }
        public int IdProveedor { get; set; }
        public String Nombre { get; set; }
        public int Precio { get; set; }
        public String Descripcion { get; set; }

        public Producto() { }

        public Producto(String nom,int pre,String des)
        {
            Nombre = nom;
            Precio = pre;
            Descripcion = des;
        }
    }
}
