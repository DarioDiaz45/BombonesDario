using Bombones2025.Entidades;
using System.Windows.Forms;



namespace Bombones2025Semi.Windows
{
    public partial class frmFrutosAE : Form
    {
        private FrutosSecos? fruto;

        public frmFrutosAE()
        {
            InitializeComponent();
        }

        public FrutosSecos GetFrutoSeco()
        {
            return fruto!;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (fruto is not null)
            {
                txtFruto.Text = fruto.NombreFruto;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (fruto is null)
                {
                    fruto = new FrutosSecos();
                }
                fruto.NombreFruto = txtFruto.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtFruto.Text))
            {
                valido = false;
                errorProvider1.SetError(txtFruto, "El nombre es requerido");
            }
            return valido;
        }

        public void SetFruto(FrutosSecos fruto)
        {
            this.fruto = fruto;
        }

        public FrutosSecos GetFruto()
        {
            return fruto!;
        }
    }
}
