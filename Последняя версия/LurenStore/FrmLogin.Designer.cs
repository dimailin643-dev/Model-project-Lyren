namespace LurenStore
{
    partial class FrmLogin
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox picHero;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlBrand = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblBrandSub = new System.Windows.Forms.Label();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.lblQuote = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLead = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            this.picHero = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlBrand.SuspendLayout();
            this.pnlLine.SuspendLayout();

            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Size = new System.Drawing.Size(100, 35);
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(248, 247, 244);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;

            this.pnlBrand.Name = "pnlBrand";
            this.pnlBrand.Location = new System.Drawing.Point(0, 0);
            this.pnlBrand.Size = new System.Drawing.Size(370, 660);
            this.pnlBrand.BackColor = System.Drawing.Color.FromArgb(31, 32, 33);
            this.pnlBrand.Dock = System.Windows.Forms.DockStyle.Left;

            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Location = new System.Drawing.Point(48, 44);
            this.lblBrand.Size = new System.Drawing.Size(277, 82);
            this.lblBrand.Text = "ЛУРЕН";
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold);
            this.lblBrand.AutoSize = false;
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblBrandSub.Name = "lblBrandSub";
            this.lblBrandSub.Location = new System.Drawing.Point(49, 123);
            this.lblBrandSub.Size = new System.Drawing.Size(275, 34);
            this.lblBrandSub.Text = "МАГАЗИН ОДЕЖДЫ";
            this.lblBrandSub.ForeColor = System.Drawing.Color.FromArgb(211, 211, 208);
            this.lblBrandSub.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);
            this.lblBrandSub.AutoSize = false;
            this.lblBrandSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Location = new System.Drawing.Point(94, 177);
            this.pnlLine.Size = new System.Drawing.Size(182, 2);
            this.pnlLine.BackColor = System.Drawing.Color.FromArgb(183, 135, 103);

            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Location = new System.Drawing.Point(29, 545);
            this.lblQuote.Size = new System.Drawing.Size(311, 36);
            this.lblQuote.Text = "СИЛУЭТ. ФАКТУРА. ХАРАКТЕР.";
            this.lblQuote.ForeColor = System.Drawing.Color.FromArgb(198, 198, 198);
            this.lblQuote.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblQuote.AutoSize = false;
            this.lblQuote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Location = new System.Drawing.Point(18, 615);
            this.lblFooter.Size = new System.Drawing.Size(334, 22);
            this.lblFooter.Text = "УЧЕБНАЯ ИНФОРМАЦИОННАЯ СИСТЕМА";
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(143, 145, 145);
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular);
            this.lblFooter.AutoSize = false;
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Location = new System.Drawing.Point(92, 124);
            this.lblTitle.Size = new System.Drawing.Size(550, 64);
            this.lblTitle.Text = "С возвращением";
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(39, 41, 43);
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitle.AutoSize = false;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblLead.Name = "lblLead";
            this.lblLead.Location = new System.Drawing.Point(96, 184);
            this.lblLead.Size = new System.Drawing.Size(550, 39);
            this.lblLead.Text = "Доступ к каталогу и базе клиентов";
            this.lblLead.ForeColor = System.Drawing.Color.FromArgb(117, 121, 125);
            this.lblLead.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.lblLead.AutoSize = false;
            this.lblLead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Location = new System.Drawing.Point(96, 251);
            this.lblLogin.Size = new System.Drawing.Size(540, 25);
            this.lblLogin.Text = "Логин";
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(39, 41, 43);
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLogin.AutoSize = false;
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Location = new System.Drawing.Point(96, 280);
            this.txtLogin.Size = new System.Drawing.Size(505, 36);
            this.txtLogin.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtLogin.ForeColor = System.Drawing.Color.FromArgb(39, 41, 43);
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.MaxLength = 100;

            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Location = new System.Drawing.Point(96, 346);
            this.lblPassword.Size = new System.Drawing.Size(540, 25);
            this.lblPassword.Text = "Пароль";
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(39, 41, 43);
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassword.AutoSize = false;
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Location = new System.Drawing.Point(96, 375);
            this.txtPassword.Size = new System.Drawing.Size(505, 36);
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(39, 41, 43);
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.MaxLength = 100;
            this.txtPassword.UseSystemPasswordChar = true;

            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Location = new System.Drawing.Point(96, 433);
            this.chkShowPassword.Size = new System.Drawing.Size(240, 27);
            this.chkShowPassword.Text = "Показать пароль";
            this.chkShowPassword.BackColor = System.Drawing.Color.FromArgb(248, 247, 244);
            this.chkShowPassword.ForeColor = System.Drawing.Color.FromArgb(117, 121, 125);
            this.chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);

            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Location = new System.Drawing.Point(96, 494);
            this.btnLogin.Size = new System.Drawing.Size(242, 49);
            this.btnLogin.Text = "ВОЙТИ";
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(154, 112, 83);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            this.btnExit.Name = "btnExit";
            this.btnExit.Location = new System.Drawing.Point(354, 494);
            this.btnExit.Size = new System.Drawing.Size(247, 49);
            this.btnExit.Text = "ВЫХОД";
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(224, 223, 219);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(39, 41, 43);
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            this.lblHint.Name = "lblHint";
            this.lblHint.Location = new System.Drawing.Point(96, 571);
            this.lblHint.Size = new System.Drawing.Size(505, 30);
            this.lblHint.Text = "Демонстрационный вход: admin / 1234";
            this.lblHint.ForeColor = System.Drawing.Color.FromArgb(117, 121, 125);
            this.lblHint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblHint.AutoSize = false;
            this.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.pnlBrand.Controls.Add(this.lblBrand);
            this.pnlBrand.Controls.Add(this.lblBrandSub);
            this.pnlBrand.Controls.Add(this.pnlLine);
            this.pnlBrand.Controls.Add(this.lblQuote);
            this.pnlBrand.Controls.Add(this.lblFooter);
            this.pnlBody.Controls.Add(this.lblTitle);
            this.pnlBody.Controls.Add(this.lblLead);
            this.pnlBody.Controls.Add(this.lblLogin);
            this.pnlBody.Controls.Add(this.txtLogin);
            this.pnlBody.Controls.Add(this.lblPassword);
            this.pnlBody.Controls.Add(this.txtPassword);
            this.pnlBody.Controls.Add(this.chkShowPassword);
            this.pnlBody.Controls.Add(this.btnLogin);
            this.pnlBody.Controls.Add(this.btnExit);
            this.pnlBody.Controls.Add(this.lblHint);
            this.picHero.Name = "picHero";
            this.picHero.Location = new System.Drawing.Point(25, 197);
            this.picHero.Size = new System.Drawing.Size(320, 315);
            this.picHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHero.BackColor = System.Drawing.Color.FromArgb(29, 31, 32);
            this.picHero.TabStop = false;
            this.Controls.Add(this.pnlBody);
            this.pnlBrand.Controls.Add(this.picHero);
            this.Controls.Add(this.pnlBrand);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 660);
            this.BackColor = System.Drawing.Color.FromArgb(248, 247, 244);
            this.Name = "FrmLogin";
            this.Text = "Авторизация - Лурен";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlBody.ResumeLayout(false);
            this.pnlBrand.ResumeLayout(false);
            this.pnlLine.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblBrandSub;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.Label lblQuote;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLead;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblHint;
    }
}
