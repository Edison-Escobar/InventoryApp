using InventoryApp.Domain;
using System;
using System.Linq;
using System.Windows.Forms;

namespace InventoryApp.WinForms
{
    public partial class ClientesForm : Form
    {
        private readonly IClientRepository _repo;
        private int? _currentId = null;

        public ClientesForm(IClientRepository repo)
        {
            InitializeComponent();
            _repo = repo;
            LoadClientes();
        }

        private void LoadClientes(string? filtro = null)
        {
            dataGridViewClients.DataSource = _repo.GetAll(filtro).ToList();
            dataGridViewClients.Columns["CreadoEn"].Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtNit.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios");
                    return;
                }

                if (_currentId == null)
                {
                    _repo.Add(new Client
                    {
                        Nombre = txtNombre.Text.Trim(),
                        Nit = txtNit.Text.Trim()
                    });
                    MessageBox.Show("Cliente agregado con éxito");
                }
                else
                {
                    _repo.Update(new Client
                    {
                        Id = _currentId.Value,
                        Nombre = txtNombre.Text.Trim(),
                        Nit = txtNit.Text.Trim()
                    });
                    MessageBox.Show("Cliente actualizado con éxito");
                }

                Limpiar();
                LoadClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtNit.Clear();
            _currentId = null;
        }

        private void dataGridViewClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridViewClients.Rows[e.RowIndex];
            _currentId = (int)row.Cells["Id"].Value;
            txtNombre.Text = row.Cells["Nombre"].Value.ToString();
            txtNit.Text = row.Cells["Nit"].Value.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            LoadClientes(txtBuscar.Text.Trim());
        }

        private void dataGridViewClients_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var id = (int)e.Row.Cells["Id"].Value;
            var confirm = MessageBox.Show(
                "¿Eliminar este cliente?",
                "Confirmación",
                MessageBoxButtons.YesNo);

            if (confirm != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }

            try
            {
                _repo.Delete(id);
                MessageBox.Show("Cliente eliminado");
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
