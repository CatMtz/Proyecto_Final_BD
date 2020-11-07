using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.MODELOS
{
    public class Nota
    {
        public int IdNota { get; set; }
        public int IdUsuario { get; set; }
        public String Descripcion { get; set; }

        public Nota() { }

        public Nota(String des)
        {
            Descripcion = des;
        }
    }
}
