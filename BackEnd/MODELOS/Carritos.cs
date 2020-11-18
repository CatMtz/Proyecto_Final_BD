using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.MODELOS
{
    public class Carritos
    {
        public int idCarrito { get; set; }
        public int idProducto { get; set; }
        public String NombreProducto { get; set; }
        public int Precio { get; set; }


        public Carritos() { }
        public Carritos(int idprod, String nom, int prec)
        {
            this.idProducto = idprod;
            this.NombreProducto = nom;
            this.Precio = prec;
        }
    }
    
}
