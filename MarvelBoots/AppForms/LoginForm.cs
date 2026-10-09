using System.Linq;
using System.Windows.Forms;
using MarvelBoots.Services;

namespace MarvelBoots.AppForms
{
    /// <summary>
    /// Форма авторизации
    /// </summary>
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
            UserExperienceService.SetTitle("Авторизация", this);
            UserExperienceService.CustomizeControls(splitContainer.Panel1.Controls);
            UserExperienceService.CustomizeControls(tableLayoutPanel1.Controls);
        }

        private void Authorize_click(object sender, System.EventArgs e)
        {
            var existing = Program.Context.User.Where(x => x.Login == textBoxLogin.Text).FirstOrDefault();

            if (existing != null)
            {
                IdentityService.User = existing;
                NavigateToProductsForm();
            }
            else
            {
                MessageBox.Show("Неверный логин!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NavigateToProductsForm()
        {
            var form = new ProductForm();
            Hide();
            form.ShowDialog();
            Show();
        }

        private void buttonActionAccent_Click(object sender, System.EventArgs e)
        {
            IdentityService.User = null;
            NavigateToProductsForm();
        }
    }
}
