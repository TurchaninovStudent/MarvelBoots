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
        private readonly Order order;

        public Action Changed;

        public OrderForm(Order order)
        {
            InitializeComponent();
            UserExperienceService.SetTitle($"Детали заказа от {order.User.FullName}", this);
            UserExperienceService.CustomizeControls(splitContainer.Panel1.Controls);
            UserExperienceService.CustomizeControls(splitContainer.Panel2.Controls);

            this.order = order;
            dateTimePickerDate.Value = order.Date;
            this.order.OrderProduct = Program.Context.OrderProduct.Where(x => x.OrderId == order.IdOrder).ToList();

            dateTimePickerDate.Visible = IdentityService.Is(Models.Enums.Role.Admin);
            buttonNewProductAccent.Visible = IdentityService.Is(Models.Enums.Role.Admin);
            buttonConfirmAccent.Visible = IdentityService.Is(Models.Enums.Role.Admin);

            Render(order.OrderProduct.ToList());
        }

        public OrderForm()
        {
            InitializeComponent();
            UserExperienceService.SetTitle("Ваша корзина", this);
            UserExperienceService.CustomizeControls(splitContainer.Panel1.Controls);
            UserExperienceService.CustomizeControls(splitContainer.Panel2.Controls);

            dateTimePickerDate.Visible = false;
            buttonNewProductAccent.Visible = false;

            Render(CartService.GetAll());
        }

        private void buttonBack_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void Render(List<OrderProduct> products)
        {
            flowLayoutPanel1.Controls.Clear();
            buttonConfirmAccent.Enabled = order != null || (order == null && products.Count > 0);

            foreach (var product in products)
            {
                var card = new OrderProductCard(product);
                card.OnRemove += () =>
                {
                    if (MessageBox.Show("Удалить этот предмет из заказа?", "Удаление предмета заказа",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }

                    if (order != null)
                    {
                        order.OrderProduct.Remove(product);
                        Program.Context.OrderProduct.Remove(product);
                        Render(order.OrderProduct.ToList());
                    }
                    else
                    {
                        CartService.RemoveOrderProduct(product);
                        Render(CartService.GetAll());
                    }
                };
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void buttonConfirmAccent_Click(object sender, System.EventArgs e)
        {
            if (order == null)
            {

                if (MessageBox.Show("Оформить заказ?", "Оформление заказа",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                try
                {
                    CartService.CreateOrder();
                    MessageBox.Show("Заказ успешно оформлен!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Render(CartService.GetAll());
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось создать заказ: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (MessageBox.Show("Сохранить изменения?", "Изменение заказа",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                try
                {
                    Program.Context.SaveChanges();
                    Changed?.Invoke();
                    MessageBox.Show("Заказ успешно сохранён!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Render(order.OrderProduct.ToList());
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось сохранить изменения: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonNewProductAccent_Click(object sender, EventArgs e)
        {
            var productForm = new ProductForm(order);
            productForm.ProductAdded += (orderProduct) =>
            {
                order.OrderProduct.Add(orderProduct);
                Render(order.OrderProduct.ToList());
            };
            productForm.ShowDialog();
        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
            if (order != null)
            {
                order.Date = dateTimePickerDate.Value;
            }
        }
    }
}
