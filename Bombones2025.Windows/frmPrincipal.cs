using Bombones2025.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bombones2025.Windows
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnPaises_Click(object sender, EventArgs e)
        {
            PaisServicio servicio = new PaisServicio("Paises.txt");
            frmPaises frm = new frmPaises(servicio) { Text = "Listado de Paises" };
            frm.ShowDialog(this);
        }
    }
}
