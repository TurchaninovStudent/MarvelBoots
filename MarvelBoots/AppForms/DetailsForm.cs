using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MarvelBoots.Models;
using MarvelBoots.Services;

namespace MarvelBoots.AppForms
{
    /// <summary>
    /// Форма авторизации
    /// </summary>
    public partial class DetailsForm : BaseForm
    {
        private readonly Product product;

        public Action<OrderProduct> OrderProductCreated { get; set; }

        public DetailsForm(Product product)
        {
            InitializeComponent();
            this.product = product;
            UserExperienceService.SetTitle(product.Name, this);
            UserExperienceService.CustomizeControls(splitContainer.Panel1.Controls);
            UserExperienceService.CustomizeControls(splitContainer.Panel2.Controls);

            Render(product);
        }

        private void buttonBack_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void Render(Product product)
        {
            labelName.Text = product.Name;
            labelManufacturer.Text = $"Производитель: {product.Manufacturer.Name}";
            labelAmount.Text = "Количество: " + (product.ProductSize.Sum(x => x.Stock) >= 5 ? "много" : "мало");
            labelSizes.Text = "Размерный ряд: " + string.Join(", ", product.ProductSize.Select(x => (int)x.Size));
            labelPrice.Text = $"Цена за штуку: {ProductPriceService.GetPrice(product):F2}";
            labelCategory.Text = "Категория: " + product.Category.Name;
            labelResources.Text = product.ProductResources;
            labelDescription.Text = product.Description;

            if (product.ImagePath != null)
            {
                try
                {
                    pictureBoxImage.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Images", product.ImagePath));
                }
                catch
                {
                    pictureBoxImage.Image = Properties.Resources.picture;
                }
            }

            foreach (var size in product.ProductSize)
            {
                if (size.Stock > 0)
                {
                    listBoxAvaibleSizes.Items.Add(size.Size);
                }
            }
        }

        private void buttonAddCartAccent_Click(object sender, EventArgs e)
        {
            var newOrder = new OrderProduct()
            {
                Size = (decimal)listBoxAvaibleSizes.SelectedItem,
                Amount = (int)numericUpDownAmount.Value,
                CategoryId = product.CategoryId,
                ManufacturerId = product.ManufacturerId,
                PricePerUnit = product.Price,
                ProductId = product.IdProduct,
                Product = product,
                Category = product.Category,
                Manufacturer = product.Manufacturer,
            };

            OrderProductCreated?.Invoke(newOrder);

            MessageBox.Show("Заказ успешно добавлен!", "Успех",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private void listBoxAvaibleSizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonAddCartAccent.Enabled = true;
            var size = (decimal)listBoxAvaibleSizes.SelectedItem;
            numericUpDownAmount.Maximum = product.ProductSize.First(x => x.Size == (decimal)listBoxAvaibleSizes.SelectedItem).Stock;
        }
    }
}
