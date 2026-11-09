using System;
using System.Data;
using System.Windows.Forms;

namespace LurenStore
{
    public partial class FrmProducts : Form
    {
        private int selectedId = 0;

        public FrmProducts()
        {
            InitializeComponent();
            picEditorial.Image = AssetImages.Load("editorial");
            picProduct.Image = AssetImages.Load("jacket");
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            RefreshProducts();
        }

        private void RefreshProducts()
        {
            try
            {
                dgvProducts.DataSource = Database.LoadProducts(txtProductSearch.Text.Trim());
                if (dgvProducts.Columns.Contains("Id")) dgvProducts.Columns["Id"].Visible = false;
                dgvProducts.Columns["Article"].HeaderText = "Артикул";
                dgvProducts.Columns["Name"].HeaderText = "Наименование";
                dgvProducts.Columns["Category"].HeaderText = "Категория";
                dgvProducts.Columns["Size"].HeaderText = "Размер";
                dgvProducts.Columns["Color"].HeaderText = "Цвет";
                dgvProducts.Columns["Price"].HeaderText = "Цена, ₽";
                dgvProducts.Columns["Price"].DefaultCellStyle.Format = "N2";
                dgvProducts.Columns["Quantity"].HeaderText = "Остаток";
                dgvProducts.ClearSelection();
                selectedId = 0;
                ClearFields();
                lblCount.Text = "Товаров найдено: " + dgvProducts.Rows.Count;
                ShowProductPhoto("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить товары:\n" + ex.Message,
                    "Лурен", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckFields()
        {
            if (txtArticle.Text.Trim() == "" || txtName.Text.Trim() == "")
            {
                MessageBox.Show("Заполните артикул и наименование товара.", "Лурен",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbCategory.Text.Trim() == "" || cmbSize.Text.Trim() == "" || txtColor.Text.Trim() == "")
            {
                MessageBox.Show("Укажите категорию, размер и цвет товара.", "Лурен",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (Database.ArticleExists(txtArticle.Text.Trim(), selectedId))
            {
                MessageBox.Show("Товар с таким артикулом уже есть в базе.", "Лурен",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int oldSelectedId = selectedId;
                selectedId = 0;
                if (!CheckFields()) { selectedId = oldSelectedId; return; }

                Database.AddProduct(txtArticle.Text.Trim(), txtName.Text.Trim(),
                    cmbCategory.Text.Trim(), cmbSize.Text.Trim(), txtColor.Text.Trim(),
                    nudPrice.Value, (int)nudQuantity.Value);
                MessageBox.Show("Товар добавлен в базу данных.", "Лурен");
                RefreshProducts();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось добавить товар:\n" + ex.Message,
                    "Лурен", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Сначала выберите товар в таблице.", "Лурен");
                return;
            }
            try
            {
                if (!CheckFields()) return;
                Database.UpdateProduct(selectedId, txtArticle.Text.Trim(), txtName.Text.Trim(),
                    cmbCategory.Text.Trim(), cmbSize.Text.Trim(), txtColor.Text.Trim(),
                    nudPrice.Value, (int)nudQuantity.Value);
                MessageBox.Show("Изменения сохранены.", "Лурен");
                RefreshProducts();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось изменить товар:\n" + ex.Message,
                    "Лурен", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Сначала выберите товар в таблице.", "Лурен");
                return;
            }
            if (MessageBox.Show("Удалить выбранный товар?", "Лурен",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                Database.DeleteProduct(selectedId);
                RefreshProducts();
                ClearFields();
                MessageBox.Show("Товар удалён.", "Лурен");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось удалить товар:\n" + ex.Message,
                    "Лурен", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e) { ClearFields(); }
        private void btnRefresh_Click(object sender, EventArgs e) { RefreshProducts(); }

        private void ClearFields()
        {
            selectedId = 0;
            txtArticle.Clear();
            txtName.Clear();
            cmbCategory.SelectedIndex = -1;
            cmbSize.SelectedIndex = -1;
            cmbSize.Text = "";
            txtColor.Clear();
            nudPrice.Value = 0;
            nudQuantity.Value = 0;
            dgvProducts.ClearSelection();
            ShowProductPhoto("");
            txtArticle.Focus();
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0) return;
            DataGridViewRow row = dgvProducts.SelectedRows[0];
            if (row.IsNewRow || !dgvProducts.Columns.Contains("Id") || row.Cells["Id"].Value == null) return;
            selectedId = Convert.ToInt32(row.Cells["Id"].Value);
            txtArticle.Text = Convert.ToString(row.Cells["Article"].Value);
            ShowProductPhoto(Convert.ToString(row.Cells["Category"].Value));
            txtName.Text = Convert.ToString(row.Cells["Name"].Value);
            cmbCategory.Text = Convert.ToString(row.Cells["Category"].Value);
            cmbSize.Text = Convert.ToString(row.Cells["Size"].Value);
            txtColor.Text = Convert.ToString(row.Cells["Color"].Value);
            nudPrice.Value = Math.Min(nudPrice.Maximum, Math.Max(nudPrice.Minimum,
                Convert.ToDecimal(row.Cells["Price"].Value)));
            nudQuantity.Value = Math.Min(nudQuantity.Maximum, Math.Max(nudQuantity.Minimum,
                Convert.ToDecimal(row.Cells["Quantity"].Value)));
        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            if (!IsHandleCreated) return;
            try
            {
                dgvProducts.DataSource = Database.LoadProducts(txtProductSearch.Text.Trim());
                lblCount.Text = "Товаров найдено: " + dgvProducts.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка поиска: " + ex.Message, "Лурен", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowProductPhoto(string category)
        {
            string photo = "jacket";
            string c = (category ?? "").ToLowerInvariant();
            if (c.Contains("джинс") || c.Contains("брюк")) photo = "jeans";
            else if (c.Contains("футбол") || c.Contains("рубаш")) photo = "tshirt";
            else if (c.Contains("толст") || c.Contains("худи")) photo = "hoodie";
            var previous = picProduct.Image;
            picProduct.Image = AssetImages.Load(photo);
            if (previous != null) previous.Dispose();
            lblPreview.Text = string.IsNullOrEmpty(category) ? "НОВАЯ КОЛЛЕКЦИЯ" : "КАТЕГОРИЯ: " + category.ToUpperInvariant();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            FrmClient f = new FrmClient();
            f.FormClosed += (s, args) => { RefreshProducts(); Show(); };
            f.Show();
            Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
