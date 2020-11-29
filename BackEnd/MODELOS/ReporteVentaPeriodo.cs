using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.MODELOS
{
    public class ReporteVentaPeriodo
    {
        public Int32 idCompra { get; set; }
        public DateTime Fecha { get; set; }
        public Decimal Cantidad_Venta { get; set; }
        public String NombreUsuario { get; set; }

        public ReporteVentaPeriodo() { }
    }
}
