using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MarvelBoots.Constants;
using MarvelBoots.Models;
using MarvelBoots.Services;

namespace MarvelBoots.CustomControls
{
    /// <summary>
    /// Карточка продукта
    /// </summary>
    public partial class ProductCard : UserControl
    {
        /// <summary>
        /// Продукт
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// Событие по добавлению в корзину
        /// </summary>
        public Action OnCartAdd;

        public ProductCard(Product product)
        {
            InitializeComponent();
            UserExperienceService.CustomizeControls(Controls);
            BackColor = ColorTranslator.FromHtml(product.ProductSize.Sum(x => x.Stock) > 3 ? AppColors.Extra : AppColors.Danger);
            Initialize(product);
        }

        private void Initialize(Product product)
        {
            labelManufacturerAndName.Text = $"{product.Manufacturer.Name} | {product.Name}";
            labelAmount.Text = "Количество: " + (product.ProductSize.Sum(x => x.Stock) >= 5 ? "много" : "мало");
            labelPrice.Text = $"Цена: {ProductPriceService.GetPrice(product):F2}";
            labelCategory.Text = "Категория: " + product.Category.Name;
            labelResources.Text = product.ProductResources;
            if (product.ImagePath != null)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Images", product.ImagePath));
                }
                catch
                {
                    pictureBox1.Image = Properties.Resources.picture;
                }
            }
        }

        private void ProductCard_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, ColorTranslator.FromHtml(AppColors.Accent), ButtonBorderStyle.Solid);
        }

        private void buttonAddToCartAccent_Click(object sender, EventArgs e)
        {
            OnCartAdd?.Invoke();
        }
    }
}
