

using Bombones2025.Entidades;
using Bombones2025.Servicios;

namespace Bombones2025Semi.Windows
{
    public partial class frmPaises : Form
    {
        private readonly PaisServicio _paisServicio;
        private List<Pais> _paises = new();

        public frmPaises(PaisServicio paisServicio)
        {
            InitializeComponent();
            _paisServicio = paisServicio;
        }

        private void frmPaises_Load(object sender, EventArgs e)
        {
            _paises = _paisServicio.GetPaises();
            MostrarDatosEnGrilla();


        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (Pais pais in _paises)
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
            r.Cells[0].Value = pais.NombrePais;
            r.Cells[1].Value = pais.PaisId;

            r.Tag = pais;
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmPaisesAE frm = new frmPaisesAE() { Text = "Nuevo Pais" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            Pais? pais = frm.GetPais();
            if (pais == null) return;
            if (!_paisServicio.Existe(pais))
            {
                _paisServicio.Guardar(pais);
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgvDatos);
                SetearFila(r, pais);
                AgregarFila(r);
                MessageBox.Show("Pais agregado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Pais Existente", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;

            }
            var r = dgvDatos.SelectedRows[0];
            Pais paisBorrar = (Pais)r.Tag!;
            DialogResult dr = MessageBox.Show($"¿Desea borrar el pais?{paisBorrar}", "Confirmar Eliminacion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            _paisServicio.Borrar(paisBorrar);
            dgvDatos.Rows.Remove(r);
            MessageBox.Show("Pais Eliminado");




        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;

            }
            var r = dgvDatos.SelectedRows[0];
            Pais? pais = (Pais)r.Tag!;
            frmPaisesAE frm = new frmPaisesAE() { Text = "Editar Pais" };
            frm.SetPais(pais);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
             pais = frm.GetPais();
            if (pais == null) return;
            if (!_paisServicio.Existe(pais))
            {
                _paisServicio.Guardar(pais);
                SetearFila(r, pais);
                MessageBox.Show("Pais editado", "Mensaje",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Pais Existente", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
