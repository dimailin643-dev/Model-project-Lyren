using System;
using System.Windows.Forms;

namespace LurenStore
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Database.Initialize();
                Application.Run(new FrmLogin());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Не удалось запустить программу.\n\n" + ex.Message,
                    "Лурен - ошибка запуска",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
