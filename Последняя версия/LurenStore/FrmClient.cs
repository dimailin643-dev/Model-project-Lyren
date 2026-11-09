using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LurenStore
{
    public partial class FrmClient : Form
    {
        private int selectedId = 0;

        public FrmClient()
        {
            InitializeComponent();
            picShowroom.Image = AssetImages.Load("showroom");
            AcceptButton = btnSave;
        }

        private void FrmClient_Load(object sender, EventArgs e)
        {
            RefreshClients();
        }

        private void RefreshClients()
        {
            try
            {
                dgvClients.DataSource = Database.LoadClients(txtSearch.Text.Trim());
                if (dgvClients.Columns.Contains("Id")) dgvClients.Columns["Id"].Visible = false;
                dgvClients.Columns["LastName"].HeaderText = "Фамилия";
                dgvClients.Columns["FirstName"].HeaderText = "Имя";
                dgvClients.Columns["MiddleName"].HeaderText = "Отчество";
                dgvClients.Columns["Phone"].HeaderText = "Телефон";
                dgvClients.Columns["Email"].HeaderText = "Эл. почта";
                dgvClients.ClearSelection();
                selectedId = 0;
                ClearFields();
                lblCount.Text = "Клиентов найдено: " + dgvClients.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить клиентов:\n" + ex.Message,
                    "Лурен", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string lastName = txtLastName.Text.Trim();
            string firstName = txtFirstName.Text.Trim();
            string middleName = txtMiddleName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            if (lastName == "" || firstName == "" || phone == "")
            {
                MessageBox.Show("Фамилия, имя и телефон обязательны.", "Лурен",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(phone, @"^\+?[0-9 ()-]{7,20}$"))
            {
                MessageBox.Show("Проверьте телефон: от 7 до 20 символов, цифры, +, пробелы и скобки.",
                    "Лурен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (email != "" && !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Укажите корректную электронную почту или оставьте поле пустым.",
                    "Лурен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (Database.PhoneExists(phone, selectedId))
                {
                    MessageBox.Show("Клиент с таким телефоном уже есть в базе.", "Лурен");
                    return;
                }
                if (selectedId == 0)
                    Database.AddClient(lastName, firstName, middleName, phone, email);
                else
                    Database.UpdateClient(selectedId, lastName, firstName, middleName, phone, email);

                MessageBox.Show("Карточка клиента сохранена.", "Лурен");
                txtSearch.Clear();
                RefreshClients();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось сохранить клиента:\n" + ex.Message,
                    "Лурен", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNew_Click(object sender, EventArgs e) { ClearFields(); }

        private void ClearFields()
        {
            selectedId = 0;
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            dgvClients.ClearSelection();
            txtLastName.Focus();
        }

        private void dgvClients_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count == 0) return;
            DataGridViewRow row = dgvClients.SelectedRows[0];
            if (row.IsNewRow || !dgvClients.Columns.Contains("Id") || row.Cells["Id"].Value == null) return;
            selectedId = Convert.ToInt32(row.Cells["Id"].Value);
            txtLastName.Text = Convert.ToString(row.Cells["LastName"].Value);
            txtFirstName.Text = Convert.ToString(row.Cells["FirstName"].Value);
            txtMiddleName.Text = Convert.ToString(row.Cells["MiddleName"].Value);
            txtPhone.Text = Convert.ToString(row.Cells["Phone"].Value);
            txtEmail.Text = Convert.ToString(row.Cells["Email"].Value);
        }

        private void btnFind_Click(object sender, EventArgs e) { RefreshClients(); }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            RefreshClients();
        }
        private void btnBack_Click(object sender, EventArgs e) { Close(); }
    }
}
