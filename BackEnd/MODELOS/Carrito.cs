using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.MODELOS
{
    public class Carrito
    {
        public int idCarrito { get; set; }
        public int idProducto { get; set; }
        public String NombreProducto { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
    }
}
