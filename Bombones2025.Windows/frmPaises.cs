

using Bombones2025.Entidades;
using Bombones2025.Servicios;

namespace Bombones2025.Windows
{
    public partial class frmPaises : Form
    {
        private readonly PaisServicio _paisSevicio;
        private List<Pais> _paises = new();
        public frmPaises(PaisServicio paisServicio)
        {
            InitializeComponent();
            _paisSevicio = paisServicio;
        }

        private void frmPaises_Load(object sender, EventArgs e)
        {
            _paises = _paisSevicio.GetPaises();
            MostrarDatosEnGrilla();


        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach(Pais pais in _paises)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgvDatos);
                SetearFila(r, pais);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Pais pais)
        {
            r.Cells[0].Value = pais.PaisId;
            r.Cells[1].Value = pais.NombrePais;
            r.Tag = pais;
        }
    }
}
