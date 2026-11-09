namespace LurenStore
{
    partial class FrmClient
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox picShowroom;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.pnlAccent = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblLead = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblList = new System.Windows.Forms.Label();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.lblCount = new System.Windows.Forms.Label();
            this.picShowroom = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlAccent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();

            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Size = new System.Drawing.Size(100, 35);
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(248, 247, 244);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;

            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Size = new System.Drawing.Size(236, 740);
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(31, 32, 33);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;

            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Location = new System.Drawing.Point(18, 51);
            this.lblBrand.Size = new System.Drawing.Size(200, 58);
            this.lblBrand.Text = "ЛУРЕН";
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Bold);
            this.lblBrand.AutoSize = false;
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblSection.Name = "lblSection";
            this.lblSection.Location = new System.Drawing.Point(14, 120);
            this.lblSection.Size = new System.Drawing.Size(210, 40);
            this.lblSection.Text = "КАРТОЧКИ КЛИЕНТОВ";
            this.lblSection.ForeColor = System.Drawing.Color.FromArgb(207, 204, 201);
            this.lblSection.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblSection.AutoSize = false;
            this.lblSection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.pnlAccent.Name = "pnlAccent";
            this.pnlAccent.Location = new System.Drawing.Point(60, 174);
            this.pnlAccent.Size = new System.Drawing.Size(114, 2);
            this.pnlAccent.BackColor = System.Drawing.Color.FromArgb(183, 135, 103);

            this.btnBack.Name = "btnBack";
            this.btnBack.Location = new System.Drawing.Point(22, 632);
            this.btnBack.Size = new System.Drawing.Size(192, 48);
            this.btnBack.Text = "← НАЗАД К ТОВАРАМ";
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(65, 66, 66);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Location = new System.Drawing.Point(30, 26);
            this.lblHeading.Size = new System.Drawing.Size(915, 56);
            this.lblHeading.Text = "Информация о клиенте";
            this.lblHeading.ForeColor = System.Drawing.Color.FromArgb(39, 41, 43);
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblHeading.AutoSize = false;
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblLead.Name = "lblLead";
            this.lblLead.Location = new System.Drawing.Point(32, 82);
            this.lblLead.Size = new System.Drawing.Size(905, 28);
            this.lblLead.Text = "Найдите клиента или сохраните новую карточку.";
            this.lblLead.ForeColor = System.Drawing.Color.FromArgb(117, 121, 125);
            this.lblLead.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblLead.AutoSize = false;
            this.lblLead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Location = new System.Drawing.Point(32, 123);
            this.lblSearch.Size = new System.Drawing.Size(530, 25);
            this.lblSearch.Text = "ПОИСК ПО ФАМИЛИИ ИЛИ ТЕЛЕФОНУ";
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(117, 121, 125);
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearch.AutoSize = false;
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Location = new System.Drawing.Point(32, 150);
            this.txtSearch.Size = new System.Drawing.Size(548, 36);
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(39, 41, 43);
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.MaxLength = 100;

            this.btnFind.Name = "btnFind";
            this.btnFind.Location = new System.Drawing.Point(595, 149);
            this.btnFind.Size = new System.Drawing.Size(115, 39);
            this.btnFind.Text = "НАЙТИ";
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(31, 32, 33);
            this.btnFind.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);

            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Location = new System.Drawing.Point(727, 149);
            this.btnRefresh.Size = new System.Drawing.Size(128, 39);
            this.btnRefresh.Text = "ОБНОВИТЬ";
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(220, 217, 212);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(39, 41, 43);
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Location = new System.Drawing.Point(32, 223);
            this.lblLastName.Size = new System.Drawing.Size(210, 24);
            this.lblLastName.Text = "ФАМИЛИЯ";
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(117, 121, 125);
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLastName.AutoSize = false;
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Location = new System.Drawing.Point(32, 252);
            this.txtLastName.Size = new System.Drawing.Size(214, 35);
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(39, 41, 43);
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.MaxLength = 100;

            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Location = new System.Drawing.Point(261, 223);
            this.lblFirstName.Size = new System.Drawing.Size(210, 24);
            this.lblFirstName.Text = "ИМЯ";
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(117, 121, 125);
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFirstName.AutoSize = false;
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Location = new System.Drawing.Point(261, 252);
            this.txtFirstName.Size = new System.Drawing.Size(214, 35);
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(39, 41, 43);
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.MaxLength = 100;

            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Location = new System.Drawing.Point(490, 223);
            this.lblMiddleName.Size = new System.Drawing.Size(210, 24);
            this.lblMiddleName.Text = "ОТЧЕСТВО";
            this.lblMiddleName.ForeColor = System.Drawing.Color.FromArgb(117, 121, 125);
            this.lblMiddleName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMiddleName.AutoSize = false;
            this.lblMiddleName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Location = new System.Drawing.Point(490, 252);
            this.txtMiddleName.Size = new System.Drawing.Size(214, 35);
            this.txtMiddleName.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtMiddleName.ForeColor = System.Drawing.Color.FromArgb(39, 41, 43);
            this.txtMiddleName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.txtMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMiddleName.MaxLength = 100;

            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Location = new System.Drawing.Point(719, 223);
            this.lblPhone.Size = new System.Drawing.Size(235, 24);
            this.lblPhone.Text = "ТЕЛЕФОН";
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(117, 121, 125);
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPhone.AutoSize = false;
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Location = new System.Drawing.Point(719, 252);
            this.txtPhone.Size = new System.Drawing.Size(240, 35);
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(39, 41, 43);
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.MaxLength = 100;

            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Location = new System.Drawing.Point(32, 310);
            this.lblEmail.Size = new System.Drawing.Size(451, 24);
            this.lblEmail.Text = "ЭЛЕКТРОННАЯ ПОЧТА (НЕОБЯЗАТЕЛЬНО)";
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(117, 121, 125);
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmail.AutoSize = false;
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Location = new System.Drawing.Point(32, 341);
            this.txtEmail.Size = new System.Drawing.Size(451, 35);
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(39, 41, 43);
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.MaxLength = 100;

            this.btnNew.Name = "btnNew";
            this.btnNew.Location = new System.Drawing.Point(504, 340);
            this.btnNew.Size = new System.Drawing.Size(218, 40);
            this.btnNew.Text = "НОВЫЙ КЛИЕНТ";
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(222, 219, 214);
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(39, 41, 43);
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);

            this.btnSave.Name = "btnSave";
            this.btnSave.Location = new System.Drawing.Point(741, 340);
            this.btnSave.Size = new System.Drawing.Size(218, 40);
            this.btnSave.Text = "СОХРАНИТЬ";
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(31, 32, 33);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.lblList.Name = "lblList";
            this.lblList.Location = new System.Drawing.Point(32, 404);
            this.lblList.Size = new System.Drawing.Size(876, 30);
            this.lblList.Text = "КАРТОЧКИ КЛИЕНТОВ";
            this.lblList.ForeColor = System.Drawing.Color.FromArgb(39, 41, 43);
            this.lblList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblList.AutoSize = false;
            this.lblList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.dgvClients.Name = "dgvClients";
            this.dgvClients.Location = new System.Drawing.Point(32, 440);
            this.dgvClients.Size = new System.Drawing.Size(927, 220);
            this.dgvClients.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dgvClients.ForeColor = System.Drawing.Color.FromArgb(39, 41, 43);
            this.dgvClients.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.dgvClients.BackgroundColor = System.Drawing.Color.White;
            this.dgvClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClients.ReadOnly = true;
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AllowUserToResizeRows = false;
            this.dgvClients.MultiSelect = false;
            this.dgvClients.RowHeadersVisible = false;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClients.EnableHeadersVisualStyles = false;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClients.ColumnHeadersHeight = 38;
            this.dgvClients.RowTemplate.Height = 35;
            this.dgvClients.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(236, 234, 230);
            this.dgvClients.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(39, 41, 43);
            this.dgvClients.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(218, 207, 194);
            this.dgvClients.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(31, 32, 33);
            this.dgvClients.GridColor = System.Drawing.Color.FromArgb(232, 232, 228);
            this.dgvClients.SelectionChanged += new System.EventHandler(this.dgvClients_SelectionChanged);

            this.lblCount.Name = "lblCount";
            this.lblCount.Location = new System.Drawing.Point(34, 679);
            this.lblCount.Size = new System.Drawing.Size(650, 30);
            this.lblCount.Text = "Клиентов найдено: 0";
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(117, 121, 125);
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblCount.AutoSize = false;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.pnlSidebar.Controls.Add(this.lblBrand);
            this.pnlSidebar.Controls.Add(this.lblSection);
            this.pnlSidebar.Controls.Add(this.pnlAccent);
            this.pnlSidebar.Controls.Add(this.btnBack);
            this.pnlMain.Controls.Add(this.lblHeading);
            this.pnlMain.Controls.Add(this.lblLead);
            this.pnlMain.Controls.Add(this.lblSearch);
            this.pnlMain.Controls.Add(this.txtSearch);
            this.pnlMain.Controls.Add(this.btnFind);
            this.pnlMain.Controls.Add(this.btnRefresh);
            this.pnlMain.Controls.Add(this.lblLastName);
            this.pnlMain.Controls.Add(this.txtLastName);
            this.pnlMain.Controls.Add(this.lblFirstName);
            this.pnlMain.Controls.Add(this.txtFirstName);
            this.pnlMain.Controls.Add(this.lblMiddleName);
            this.pnlMain.Controls.Add(this.txtMiddleName);
            this.pnlMain.Controls.Add(this.lblPhone);
            this.pnlMain.Controls.Add(this.txtPhone);
            this.pnlMain.Controls.Add(this.lblEmail);
            this.pnlMain.Controls.Add(this.txtEmail);
            this.pnlMain.Controls.Add(this.btnNew);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.lblList);
            this.pnlMain.Controls.Add(this.dgvClients);
            this.pnlMain.Controls.Add(this.lblCount);
            this.picShowroom.Name = "picShowroom";
            this.picShowroom.Location = new System.Drawing.Point(22, 251);
            this.picShowroom.Size = new System.Drawing.Size(192, 326);
            this.picShowroom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShowroom.BackColor = System.Drawing.Color.FromArgb(26, 27, 28);
            this.picShowroom.TabStop = false;
            this.Controls.Add(this.pnlMain);
            this.pnlSidebar.Controls.Add(this.picShowroom);
            this.Controls.Add(this.pnlSidebar);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 740);
            this.BackColor = System.Drawing.Color.FromArgb(248, 247, 244);
            this.Name = "FrmClient";
            this.Text = "Лурен - Информация о клиенте";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Load += new System.EventHandler(this.FrmClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlAccent.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Panel pnlAccent;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblLead;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Label lblCount;
    }
}
