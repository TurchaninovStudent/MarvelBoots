using System;
using System.Windows.Forms;
using MarvelBoots.AppForms;
using MarvelBoots.Models;

namespace MarvelBoots
{
    internal static class Program
    {
        public static MarvelBootsDbContext Context = new MarvelBootsDbContext();

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!Context.Database.Exists())
            {
                MessageBox.Show("Не удалось подключиться к базе данных", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
