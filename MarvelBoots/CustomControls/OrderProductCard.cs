using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MarvelBoots.Constants;
using MarvelBoots.Models;
using MarvelBoots.Services;

namespace MarvelBoots.CustomControls
{
    /// <summary>
    /// Карточка заказа продукта
    /// </summary>
    public partial class OrderProductCard : UserControl
    {
        /// <summary>
        /// Событие по удалении из корзину
        /// </summary>
        public Action OnRemove;

        public OrderProductCard(OrderProduct product)
        {
            InitializeComponent();
            UserExperienceService.CustomizeControls(Controls);
            BackColor = ColorTranslator.FromHtml(AppColors.Extra);
            Initialize(product);
        }

        private void Initialize(OrderProduct orderProduct)
        {
            var product = orderProduct.Product;
            labelManufacturerAndName.Text = $"{product.Manufacturer.Name} | {product.Name}";
            labelPrice.Text = $"Цена: {ProductPriceService.GetPrice(product):F2}";
            labelCategory.Text = "Категория: " + product.Category.Name;
            buttonRemoveAccent.Visible = orderProduct.OrderId == 0 || (orderProduct.OrderId != 0 && IdentityService.Is(Models.Enums.Role.Admin));
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

            labelAmount.Text = "Количество: " + orderProduct.Amount;
            labelSize.Text = "Размер: " + orderProduct.Size;
        }

        private void ProductCard_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, ColorTranslator.FromHtml(AppColors.Accent), ButtonBorderStyle.Solid);
        }

        private void buttonAddToCartAccent_Click(object sender, EventArgs e)
        {
            OnRemove?.Invoke();
        }
    }
}
