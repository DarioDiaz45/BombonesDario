using Bombones2025.Entidades;
using System;


namespace Bombones2025Semi.Windows
{
    public partial class frmPaisesAE : Form
    {
        private Pais? pais;
        public frmPaisesAE()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if(pais is not null )
            {
                txtPais.Text = pais.NombrePais;
            }
        }



        public Pais? GetPais()
        {
            return pais;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (pais is null)
                {
                    pais = new Pais(); 
                }
                pais.NombrePais = txtPais.Text;
                DialogResult = DialogResult.OK;
            }
        }
        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if(string.IsNullOrEmpty(txtPais.Text) )
            {
                valido = false;
                errorProvider1.SetError(txtPais, "El nombre es requerido");
            }
            return valido;
        }

        public void SetPais(Pais pais)
        {
            this.pais = pais;
        }

       
    }
}
