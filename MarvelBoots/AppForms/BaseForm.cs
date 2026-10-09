using System.Drawing;
using System.Windows.Forms;
using MarvelBoots.Constants;

namespace MarvelBoots.AppForms
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            splitContainer.Panel1.BackColor = ColorTranslator.FromHtml(AppColors.Extra);
        }
    }
}
