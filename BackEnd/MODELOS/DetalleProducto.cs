using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.MODELOS
{
   public class DetalleProducto
    {
        public int idCarrito { get; set; }
        public int idProducto { get; set; }
        public decimal Precio { get; set; }
        public int cantidad { get; set; }

        public DetalleProducto() { }
        public DetalleProducto(int prod,decimal pre,int cant)
        {
          
            this.idProducto = prod;
            this.Precio = pre;
            this.cantidad = cant;
        }

    }
}
