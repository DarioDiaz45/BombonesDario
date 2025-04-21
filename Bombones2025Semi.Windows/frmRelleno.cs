

using Bombones2025.Entidades;
using Bombones2025.Servicios;

namespace Bombones2025Semi.Windows
{
    public partial class frmRelleno : Form
    {
        private readonly RellenoServicios _rellenoServicios;
        private List<Relleno> _rellenos = new();
        public frmRelleno(RellenoServicios rellenoServicios)
        {
            InitializeComponent();
            _rellenoServicios = rellenoServicios;
        }

        private void frmRelleno_Load(object sender, EventArgs e)
        {
            _rellenos = _rellenoServicios.GetRellenos();
            MostrarDatosEnGrilla();
        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (Relleno relleno in _rellenos)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgvDatos);
                SetearFila(r, relleno);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Relleno relleno)
        {
            r.Cells[0].Value = relleno.NombreRelleno;
            r.Cells[1].Value = relleno.IdRelleno;

            r.Tag = relleno;
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmRellenoAE frm = new frmRellenoAE() { Text = "Nuevo Relleno" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            Relleno? relleno = frm.GetRelleno();
            if (relleno == null) return;
            if (!_rellenoServicios.Existe(relleno))
            {
                _rellenoServicios.Guardar(relleno);
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgvDatos);
                SetearFila(r, relleno);
                AgregarFila(r);
                MessageBox.Show("Relleno agregado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Relleno Existente", "Error",
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
            Relleno rellenoBorrar = (Relleno)r.Tag!;
            DialogResult dr = MessageBox.Show($"¿Desea borrar el relleno?{rellenoBorrar}", "Confirmar Eliminacion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            _rellenoServicios.Borrar(rellenoBorrar);
            dgvDatos.Rows.Remove(r);
            MessageBox.Show("Relleno Eliminado");
        }
    }
}
