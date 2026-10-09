using System;
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
    public partial class ProductForm : BaseForm
    {
        private List<Product> cache;

        public ProductForm()
        {
            InitializeComponent();
            UserExperienceService.SetTitle("Список товаров", this);
            UserExperienceService.CustomizeControls(splitContainer.Panel1.Controls);
            UserExperienceService.CustomizeControls(splitContainer.Panel2.Controls);

            labelFullName.Text = IdentityService.IsAuthorized
                ? IdentityService.User.FullName + Environment.NewLine + IdentityService.User.UserRole.Name
                : "Гость";
            LoadProducts();
            InitializeCategoryCombo();
        }

        private void InitializeCategoryCombo()
        {
            comboBoxCategory.Items.Clear();
            comboBoxCategory.Items.Add("Все категории");
            foreach (var categoryName in Program.Context.Category.Select(x => x.Name))
            {
                comboBoxCategory.Items.Add(categoryName);
            }
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

        private void Filter()
        {
            flowLayoutPanel1.Controls.Clear();

            var toFilter = cache.AsQueryable();
            toFilter = cache.Where(x => x.Name.ToLower().Contains(searchTerm.Text.ToLower())
                || x.Description.ToLower().Contains(searchTerm.Text.ToLower())).AsQueryable();

            if (comboBoxCategory.SelectedIndex != 0)
            {
                toFilter = toFilter.Where(x => x.Category.Name == comboBoxCategory.SelectedItem.ToString());
            }

            switch (comboBoxSort.SelectedIndex)
            {
                case 0:
                    toFilter = toFilter.OrderBy(x => x.Price);
                    break;

                case 1:
                    toFilter = toFilter.OrderByDescending(x => x.Price);
                    break;
            }

            Render(toFilter.ToList());
        }

        private void Render(List<Product> products)
        {
            foreach (var product in products)
            {
                var card = new ProductCard(product);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void searchTerm_TextChanged(object sender, System.EventArgs e)
        {
            Filter();
        }

        private void ProductForm_Load(object sender, System.EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turchaninov_ae_marvelbootsDataSet.Manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.turchaninov_ae_marvelbootsDataSet.Manufacturer);

        }

        private void comboBoxManufacturer_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Filter();
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }
    }
}
