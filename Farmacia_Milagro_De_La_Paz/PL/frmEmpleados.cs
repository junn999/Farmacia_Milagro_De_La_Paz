using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia_Milagro_De_La_Paz.PL
{
    public partial class frmEmpleados : Form
    {
        EmpleadosDall sedes;
        public frmSedes()
        {
            InitializeComponent();
            sedes = new SedesDAL();
        }

        private void frmSedes_Load(object sender, EventArgs e)
        {
            fillDgvSedes();
        }

        private void fillDgvSedes()
        {
            dgvSedes.DataSource = sedes.getAllSedes();
        }

        private void clearTextBox()
        {
            txtId.Clear();
            txtSede.Clear();
            txtUbicacion.Clear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSede.Text) || string.IsNullOrEmpty(txtUbicacion.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                string nombre = txtSede.Text;
                string ubicacion = txtUbicacion.Text;
                SedesBLL sede = new SedesBLL(0, nombre, ubicacion);
                if (sedes.createSede(sede))
                {
                    MessageBox.Show("La nueva sede se creó con éxito");
                    fillDgvSedes();
                    clearTextBox();
                }
                else
                {
                    MessageBox.Show("No se pudo crear la nueva sede");
                }
            }
        }

        private void dgvSedes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtId.Text = dgvSedes.Rows[index].Cells[0].Value.ToString();
                txtSede.Text = dgvSedes.Rows[index].Cells[1].Value.ToString();
                txtUbicacion.Text = dgvSedes.Rows[index].Cells[2].Value.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtSede.Text) || string.IsNullOrEmpty(txtUbicacion.Text))
            {
                MessageBox.Show("Debe completar todos los campos requeridos");
            }
            else
            {
                int id = int.Parse(txtId.Text);
                string nombre = txtSede.Text;
                string ubicacion = txtUbicacion.Text;
                SedesBLL sede = new SedesBLL(id, nombre, ubicacion);
                SedesDAL create = new SedesDAL();
                if (create.updateSede(sede))
                {
                    MessageBox.Show("Sede actualizada con éxito");
                    fillDgvSedes();
                    clearTextBox();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la sede");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Debe seleccionar una sede");
            }
            else
            {
                int id = int.Parse(txtId.Text);
                SedesBLL sede = new SedesBLL(id);
                var confirm = MessageBox.Show("¿Estás seguro de eliminar esta sede?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    if (sedes.deleteSede(sede))
                    {
                        MessageBox.Show("Sede eliminada con éxito");
                        fillDgvSedes();
                        clearTextBox();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la sede");
                    }
                }
            }
        }
    }
}
