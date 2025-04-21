using Bombones2025.Entidades;
using Bombones2025.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Bombones2025Semi.Windows
{
    public partial class frmFrutos : Form
    {
        private readonly FrutosServicios _frutosServicios;
        private List<FrutosSecos> _listaFrutos = new();
        public frmFrutos(FrutosServicios servicio)
        {
            InitializeComponent();
            _frutosServicios = servicio;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmFrutosAE frm = new frmFrutosAE() { Text = "Nuevo Fruto Seco" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            FrutosSecos fruto = frm.GetFrutoSeco();
            _frutosServicios.AgregarFrutoSeco(fruto);
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgvDatos);
            SetearFila(fila, fruto);
            AgregarFila(fila);
            MessageBox.Show("Fruto seco agregado", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmFrutos_Load(object sender, EventArgs e)
        {

            _listaFrutos = _frutosServicios.ListarFrutosSecos();
            MostrarDatosEnGrilla();
        }



        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (var fruto in _listaFrutos)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgvDatos);
                SetearFila(r, fruto);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow fila)
        {
            dgvDatos.Rows.Add(fila);
        }

        private void SetearFila(DataGridViewRow r, FrutosSecos fruto)
        {
            r.Cells[0].Value = fruto.IdFruto;
            r.Cells[1].Value = fruto.NombreFruto;


            r.Tag = fruto;
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;

            }
            var r = dgvDatos.SelectedRows[0];
            FrutosSecos frutoBorrar = (FrutosSecos)r.Tag!;
            DialogResult dr = MessageBox.Show($"¿Desea borrar el Fruto? {frutoBorrar}", "Confirmar Eliminacion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            _frutosServicios.Borrar(frutoBorrar);
            dgvDatos.Rows.Remove(r);
            MessageBox.Show("Fruto Eliminado");
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;

            }
            var r = dgvDatos.SelectedRows[0];
            FrutosSecos? fruto = (FrutosSecos)r.Tag!;

            frmFrutosAE frm = new frmFrutosAE() { Text = "Editar Fruto" };
            frm.SetFruto(fruto);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            fruto = frm.GetFruto();
            if (fruto == null) return;
            if (!_frutosServicios.Existe(fruto))
            {
                _frutosServicios.Guardar(fruto);
                SetearFila(r, fruto);
                MessageBox.Show("Fruto editado", "Mensaje",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fruto Existente", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
