

using Bombones2025.Entidades;
using Bombones2025.Servicios;

namespace Bombones2025Semi.Windows
{
    public partial class frmChocolate : Form
    {
        private readonly ChocolateServicios _chocolateServicios;
        private List<TipoChocolate> _listaChocolates = new();
        public frmChocolate(ChocolateServicios servicio)
        {
            InitializeComponent();
            _chocolateServicios = servicio;

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmChocolateAE frm = new frmChocolateAE() { Text = "Nuevo Tipo de Chocolate" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            TipoChocolate chocolate = frm.GetChocolate();
            _chocolateServicios.Agregar(chocolate);
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgvDatos);
            SetearFila(fila, chocolate);
            AgregarFila(fila);
            MessageBox.Show("Chocolate agregado", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }


        private void SetearFila(DataGridViewRow r, TipoChocolate chocolate)
        {
            r.Cells[0].Value = chocolate.NombreChocolate;
            r.Cells[1].Value = chocolate.IdChocolate;

            r.Tag = chocolate;
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;

            }
            var r = dgvDatos.SelectedRows[0];
            TipoChocolate chocolateBorrar = (TipoChocolate)r.Tag!;
            DialogResult dr = MessageBox.Show($"¿Desea borrar el chocolate?{chocolateBorrar}", "Confirmar Eliminacion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            _chocolateServicios.Borrar(chocolateBorrar);
            dgvDatos.Rows.Remove(r);
            MessageBox.Show("Chocolate Eliminado");
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;

            }
            var r = dgvDatos.SelectedRows[0];
            TipoChocolate? chocolate = (TipoChocolate)r.Tag!;
            frmChocolateAE frm = new frmChocolateAE() { Text = "Editar Chocolate" };
            frm.SetChocolate(chocolate);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            chocolate = frm.GetChocolate();
            if (chocolate == null) return;
            if (!_chocolateServicios.Existe(chocolate))
            {
                _chocolateServicios.Guardar(chocolate);
                SetearFila(r, chocolate);
                MessageBox.Show("Chocolate Editado", "Mensaje",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Pais Existente", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmChocolate_Load(object sender, EventArgs e)
        {
            _listaChocolates = _chocolateServicios.GetChocolate();
            MostrarDatosEnGrilla();
        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (TipoChocolate chocolate in _listaChocolates)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgvDatos);
                SetearFila(r, chocolate);
                AgregarFila(r);
            }
        }
    }

}
