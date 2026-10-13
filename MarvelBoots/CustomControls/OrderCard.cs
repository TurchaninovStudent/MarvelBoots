using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MarvelBoots.Constants;
using MarvelBoots.Models;
using MarvelBoots.Services;

namespace MarvelBoots.CustomControls
{
    /// <summary>
    /// Карточка заказа продуктов
    /// </summary>
    public partial class OrderCard : UserControl
    {
        /// <summary>
        /// Событие по удалении заказа
        /// </summary>
        public Action OnRemove;

        /// <summary>
        /// Событие по просмотре деталей заказа
        /// </summary>
        public Action OnDetails;

        public OrderCard(Order order)
        {
            InitializeComponent();
            UserExperienceService.CustomizeControls(Controls);
            BackColor = ColorTranslator.FromHtml(AppColors.Extra);
            Initialize(order);
        }

        private void Initialize(Order order)
        {
            labelPrice.Text = $"Цена: {order.OrderProduct.Sum(x => x.Amount * x.PricePerUnit)}";
            labelUser.Text = "Клиент: " + order.User.FullName;
            labelDate.Text = "Дата: " + order.Date.ToLongDateString();
        }

        private void ProductCard_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, ColorTranslator.FromHtml(AppColors.Accent), ButtonBorderStyle.Solid);
        }

        private void buttonAddToCartAccent_Click(object sender, EventArgs e)
        {
            OnRemove?.Invoke();
        }

        private void OrderCard_Click(object sender, EventArgs e)
        {
            OnDetails?.Invoke();
        }
    }
}
