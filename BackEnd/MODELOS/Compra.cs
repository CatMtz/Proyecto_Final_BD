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
        public String Descripcion { get; set; }

        public Compra() { }

        public Compra(int usu,String des) {

            this.idUsuario = usu;
            this.Descripcion = des;
        }

    }
}
