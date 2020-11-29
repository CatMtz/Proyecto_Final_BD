using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.MODELOS
{
    public class ReporteCliente
    {
        public String idUsuario { get; set; }
        public String NombreUsuario { get; set; }
        public Int64 Cantidad_Compras { get; set; }
        public Decimal Cantidad_Total { get; set; }

        public ReporteCliente() { }
    }
}
