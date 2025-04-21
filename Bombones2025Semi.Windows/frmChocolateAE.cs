using Bombones2025.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bombones2025Semi.Windows
{
    public partial class frmChocolateAE : Form
    {
        private TipoChocolate? chocolate;
        public frmChocolateAE()
        {
            InitializeComponent();
        }

        internal TipoChocolate GetChocolate()
        {
            return chocolate!;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (chocolate is null)
                {
                    chocolate = new TipoChocolate();
                }
                chocolate.NombreChocolate = txtChocolate.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtChocolate.Text))
            {
                valido = false;
                errorProvider1.SetError(txtChocolate, "El nombre es requerido");
            }
            return valido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        internal void SetChocolate(TipoChocolate chocolate)
        {
            this.chocolate = chocolate;
        }
    }
}
