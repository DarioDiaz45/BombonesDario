using Bombones2025.Entidades;
using System;

namespace Bombones2025Semi.Windows
{
    public partial class frmRellenoAE : Form
    {
        private Relleno? relleno;
        public frmRellenoAE()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (relleno is not null)
            {
                txtRelleno.Text = relleno.NombreRelleno;
            }
        }

        internal Relleno? GetRelleno()
        {
            return relleno;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (relleno is null)
                {
                    relleno = new Relleno();
                }
                relleno.NombreRelleno = txtRelleno.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtRelleno.Text))
            {
                valido = false;
                errorProvider1.SetError(txtRelleno, "El nombre es requerido");
            }
            return valido;
        }
    }
}
