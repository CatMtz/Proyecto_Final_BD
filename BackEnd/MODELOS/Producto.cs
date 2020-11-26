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
        public String Nombre { get; set; }
        public Decimal Precio { get; set; }
        public String Descripcion { get; set; }
        public String Categoria { get; set; }

        public Producto() { }

        public Producto(String nom,decimal pre,String des,String cat)
        {
            Nombre = nom;
            Precio = pre;
            Descripcion = des;
            Categoria = cat;
        }
    }
}
