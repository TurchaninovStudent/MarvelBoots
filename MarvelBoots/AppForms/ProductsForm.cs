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
        private Order forOrder;
        private List<Product> cache;

        public Action<OrderProduct> ProductAdded;

        public ProductForm(Order order)
        {
            forOrder = order;
            Initialize();
        }

        public ProductForm()
        {
            Initialize();
        }

        private void Initialize()
        {
            InitializeComponent();
            UserExperienceService.SetTitle("Список товаров", this);
            UserExperienceService.CustomizeControls(splitContainer.Panel1.Controls);
            UserExperienceService.CustomizeControls(splitContainer.Panel2.Controls);

            LoadProducts();
            InitializeCategoryCombo();

            buttonOrdersAccent.Visible = IdentityService.Is(Models.Enums.Role.Manager)
                || IdentityService.Is(Models.Enums.Role.Admin);

            splitContainerFilter.Panel1Collapsed = IdentityService.Is(Models.Enums.Role.Guest);

            buttonCartAccent.Visible = !IdentityService.Is(Models.Enums.Role.Guest);
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
                cache = Program.Context.ProductSize.Where(x => x.Stock > 0).Select(x => x.Product).Distinct().ToList();
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

            if (comboBoxCategory.SelectedIndex > 0)
            {
                toFilter = toFilter.Where(x => x.Category.Name == comboBoxCategory.SelectedItem.ToString());
            }

            if (radioButtonLessFirst.Checked)
            {
                toFilter = toFilter.OrderBy(x => x.Price);
            }
            else if (radioButtonExpensiveFirst.Checked)
            {
                toFilter = toFilter.OrderByDescending(x => x.Price);
            }

            Render(toFilter.ToList());
        }

        private void Render(List<Product> products)
        {
            foreach (var product in products)
            {
                var card = new ProductCard(product);
                card.OnDetails += () =>
                {
                    var detailsForm = new DetailsForm(product);
                    detailsForm.OrderProductCreated += (orderProduct) =>
                    {
                        if (forOrder != null)
                        {
                            ProductAdded.Invoke(orderProduct);
                        }
                        else
                        {
                            CartService.AddOrderProduct(orderProduct);
                        }
                    };
                    detailsForm.ShowDialog();
                };
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

        private void buttonOrdersAccent_Click(object sender, EventArgs e)
        {
            new OrdersForm().ShowDialog();
        }

        private void radioButtonFirst_CheckedChanged(object sender, EventArgs e)
        {
            Filter();
        }
    }
}
