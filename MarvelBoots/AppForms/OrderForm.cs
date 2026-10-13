using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MarvelBoots.CustomControls;
using MarvelBoots.Models;
using MarvelBoots.Services;

namespace MarvelBoots.AppForms
{
    /// <summary>
    /// Форма заказов
    /// </summary>
    public partial class OrderForm : BaseForm
    {
        public OrderForm(Order order)
        {
            InitializeComponent();
            UserExperienceService.SetTitle($"Детали заказа от {order.User.FullName}", this);
            UserExperienceService.CustomizeControls(splitContainer.Panel1.Controls);
            UserExperienceService.CustomizeControls(splitContainer.Panel2.Controls);

            Render(order.OrderProduct.ToList());
        }

        public OrderForm()
        {
            InitializeComponent();
            UserExperienceService.SetTitle("Ваша корзина", this);
            UserExperienceService.CustomizeControls(splitContainer.Panel1.Controls);
            UserExperienceService.CustomizeControls(splitContainer.Panel2.Controls);

            Render(CartService.GetAll());
        }

        private void buttonBack_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void Render(List<OrderProduct> products)
        {
            flowLayoutPanel1.Controls.Clear();
            buttonConfirmAccent.Enabled = products.Count > 0;

            foreach (var product in products)
            {
                var card = new OrderProductCard(product);
                card.OnRemove += () =>
                {
                    CartService.RemoveOrderProduct(product);
                    Render(CartService.GetAll());
                };
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void buttonConfirmAccent_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Оформить заказ?", "Оформление заказа",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
                CartService.CreateOrder();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось создать заказ: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
