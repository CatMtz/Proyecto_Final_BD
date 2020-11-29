using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.MODELOS
{
   public class Compra
    {
        public int idCompra { get; set; }
        public int idUsuario { get; set; }
        public String NombreUsuario { get; set; }
        public String Descripcion { get; set; }
        public Decimal CantidadVenta { get; set; }

        public Compra() { }

        public Compra(int usu,String nom,String des,Decimal cant) {

            this.idUsuario = usu;
            this.NombreUsuario = nom;
            this.Descripcion = des;
            this.CantidadVenta = cant;
        }

    }
}
