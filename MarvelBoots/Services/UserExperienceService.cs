using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MarvelBoots.Constants;

namespace MarvelBoots.Services
{
    /// <summary>
    /// Сервис для кастомизации интерфейса
    /// </summary>
    public static class UserExperienceService
    {
        /// <summary>
        /// Установить заголовок
        /// </summary>
        /// <param name="title">Заголовок</param>
        /// <param name="form">форма</param>
        public static void SetTitle(string title, Form form)
        {
            form.Text = "\"Чудо обувь\": " + title;
            var formTitle = form.Controls.Find("title", true).FirstOrDefault();
            if (formTitle != null)
            {
                formTitle.Text = title;
            }
        }

        public static void CustomizeControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control.Name.EndsWith("Accent"))
                {
                    control.BackColor = ColorTranslator.FromHtml(AppColors.Accent);
                    control.ForeColor = Color.White;
                }

                if (control.Name.EndsWith("Extra"))
                {
                    control.BackColor = ColorTranslator.FromHtml(AppColors.Extra);
                }
            }
        }
    }
}
