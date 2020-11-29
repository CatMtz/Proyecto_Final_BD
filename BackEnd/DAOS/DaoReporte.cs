using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.MODELOS;
using BackEnd.DAOS;
using MySql.Data.MySqlClient;
using System.Data;

namespace BackEnd.DAOS
{
    public class DaoReporte
    {
        public List<ReporteCliente> getReporteCliente(int anio, int mes)
        {
            ConexionMySQL con = null;
            try
            {
                List<ReporteCliente> lista = new List<ReporteCliente>();
                con = new ConexionMySQL();

                DataSet dat = con.LLenaComboGrid("call Reporte_Compras_Cliente('" + anio + "','" + mes + "')" + ";");
                DataTable dt = dat.Tables[0];
                ReporteCliente datos;
                foreach (DataRow r in dt.Rows)
                {
                    datos = new ReporteCliente();
                    datos.idUsuario = (String)r.ItemArray[0];
                    datos.NombreUsuario = (String)r.ItemArray[1];
                    datos.Cantidad_Compras = (Int64)r.ItemArray[2];
                    datos.Cantidad_Total = (Decimal)r.ItemArray[3];

                    lista.Add(datos);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo traer el reporte");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FechaI"></param>
        /// <param name="FechaF"></param>
        /// <returns></returns>
        public List<ReporteVentaPeriodo> getReporteVentasPeriodo(String FechaI, String FechaF)
        {
            ConexionMySQL con = null;
            try
            {

                List<ReporteVentaPeriodo> lista = new List<ReporteVentaPeriodo>();
                con = new ConexionMySQL();

                DataSet dat = con.LLenaComboGrid("call Reporte_Ventas_Periodo('" + FechaI + "','" + FechaF + "')" + ";");
                DataTable dt = dat.Tables[0];
                ReporteVentaPeriodo datos;
                foreach (DataRow r in dt.Rows)
                {
                    datos = new ReporteVentaPeriodo();
                    datos.idCompra = (Int32)r.ItemArray[0];
                    datos.Fecha = (DateTime)r.ItemArray[1];
                    datos.Cantidad_Venta = (Decimal)r.ItemArray[2];
                    datos.NombreUsuario = (String)r.ItemArray[3];

                    lista.Add(datos);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo traer el reporte");
            }
        }


    }
}
