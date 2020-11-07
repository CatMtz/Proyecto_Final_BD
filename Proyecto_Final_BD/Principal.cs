using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_BD
{
    public partial class Principal : Form
    {
        public static int idusuario;
        public Principal()
        {
            InitializeComponent();
        }
        public Principal(int id)
        {
            idusuario = id;
        }
    }
}
