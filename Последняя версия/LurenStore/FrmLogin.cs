using System;
using System.Windows.Forms;

namespace LurenStore
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            AcceptButton = btnLogin;
            picHero.Image = AssetImages.Load("hero");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text;

            if (login == "" || password == "")
            {
                MessageBox.Show("Введите логин и пароль.", "Лурен",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (!Database.CheckLogin(login, password))
                {
                    MessageBox.Show("Неверный логин или пароль.", "Лурен",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.SelectAll();
                    txtPassword.Focus();
                    return;
                }

                FrmProducts f = new FrmProducts();
                f.FormClosed += (s, args) =>
                {
                    txtPassword.Clear();
                    Show();
                };
                f.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка базы данных:\n" + ex.Message, "Лурен",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
