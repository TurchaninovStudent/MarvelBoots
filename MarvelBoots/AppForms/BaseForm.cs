using System;
using System.Drawing;
using System.Windows.Forms;
using MarvelBoots.Constants;
using MarvelBoots.Services;

namespace MarvelBoots.AppForms
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            splitContainer.Panel1.BackColor = ColorTranslator.FromHtml(AppColors.Extra);

            labelFullName.Text = IdentityService.IsAuthorized
                ? IdentityService.User.FullName + Environment.NewLine + IdentityService.User.UserRole.Name
                : "Гость";
        }

        private void buttonCartAccent_Click(object sender, EventArgs e)
        {
            new OrderForm().ShowDialog();
        }
    }
}
