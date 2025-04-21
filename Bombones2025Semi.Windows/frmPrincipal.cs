

using Bombones2025.Servicios;

namespace Bombones2025Semi.Windows
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

        private void btnFrutos_Click(object sender, EventArgs e)
        {
            FrutosServicios servicioFrutos = new FrutosServicios("frutos_secos.txt");
            frmFrutos frmFrutos = new frmFrutos(servicioFrutos) { Text = "Listado de Frutos Secos" };
            frmFrutos.ShowDialog(this);
        }

        private void btnRelleno_Click(object sender, EventArgs e)
        {
            RellenoServicios servicioRelleno = new RellenoServicios("Relleno.txt");
            frmRelleno frmRelleno = new frmRelleno(servicioRelleno) { Text = "Listado de Rellenos" };
            frmRelleno.ShowDialog(this);
        }

        private void btnChocolate_Click(object sender, EventArgs e)
        {
            ChocolateServicios servicioChocolate = new ChocolateServicios("Chocolates.txt");
            frmChocolate frmChocolate = new frmChocolate(servicioChocolate) { Text = "Listado de Chocolates" };
            frmChocolate.ShowDialog(this);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

