using System.Collections.Generic;
using System.Linq;
using MarvelBoots.CustomControls;
using MarvelBoots.Models;
using MarvelBoots.Services;

namespace MarvelBoots.AppForms
{
    /// <summary>
    /// Форма авторизации
    /// </summary>
    public partial class OrdersForm : BaseForm
    {
        private List<Product> cache;

        public OrdersForm()
        {
            InitializeComponent();
            UserExperienceService.SetTitle("Список заказов", this);
            UserExperienceService.CustomizeControls(splitContainer.Panel1.Controls);
            UserExperienceService.CustomizeControls(splitContainer.Panel2.Controls);

            labelFullName.Text = IdentityService.IsAuthorized ? IdentityService.User.FullName : "Гость";
            LoadProducts();
        }

        private void LoadProducts()
        {
            flowLayoutPanel1.Controls.Clear();
            if (cache == null)
            {
                cache = Program.Context.Product.ToList();
            }

            Render(cache);
        }

        private void buttonUnauthorize_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void Render(List<Product> products)
        {
            foreach (var product in products)
            {
                var card = new ProductCard(product);
                flowLayoutPanel1.Controls.Add(card);
            }
        }
    }
}
