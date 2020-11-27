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
        public int idUsuario { get; set; }
        public int idProducto { get; set; }
        public String NombreProducto { get; set; }
        public DateTime FechaCompra { get; set; }
        public decimal Precio { get; set; }
        public int cantidad { get; set; }
        public decimal Total { get; set; }


        public Carritos() { }
        public Carritos(int usu,int idprod, String nom)
        {
            this.idUsuario = usu;
            this.idProducto = idprod;
            this.NombreProducto = nom;
            
        }
    }
    
}
