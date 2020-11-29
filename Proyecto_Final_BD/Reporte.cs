using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd.MODELOS;
using BackEnd.DAOS;

namespace Proyecto_Final_BD
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void btnClienteMes_Click(object sender, EventArgs e)
        {
            if (txtAnio!= null && txtMes != null )
            {
                grvReportes.DataSource = null;
                grvReportes.DataSource= new DaoReporte().getReporteCliente(int.Parse(txtAnio.Text), int.Parse(txtMes.Text));
            }else
            {
                MessageBox.Show("Favor de llenar ambos espacios");
            }
        }

        private void btnVentasPeriodo_Click(object sender, EventArgs e)
        {
            if (txtFechaI != null && txtFechaF != null)
            {
                grvReportes.DataSource = null;
                grvReportes.DataSource = new DaoReporte().getReporteVentasPeriodo(txtFechaI.Text,txtFechaF.Text);
            }
            else
            {
                MessageBox.Show("Favor de llenar ambos espacios");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            new Principal().Show();
            this.Dispose();
        }
    }
}
