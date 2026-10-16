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
    /// Форма авторизации
    /// </summary>
    public partial class OrdersForm : BaseForm
    {
        private List<Order> cache;

        public OrdersForm()
        {
            InitializeComponent();
            UserExperienceService.SetTitle("Список заказов", this);
            UserExperienceService.CustomizeControls(splitContainer.Panel1.Controls);
            UserExperienceService.CustomizeControls(splitContainer.Panel2.Controls);

            LoadOrders();
        }

        private void LoadOrders()
        {
            flowLayoutPanel1.Controls.Clear();
            if (cache == null)
            {
                cache = Program.Context.Order.OrderByDescending(x => x.Date).ToList();
            }

            Render(cache);
        }

        private void buttonUnauthorize_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InvalidateCacheAndLoad()
        {
            cache = null;
            LoadOrders();
        }

        private void Render(List<Order> orders)
        {
            foreach (var order in orders)
            {
                var card = new OrderCard(order);
                card.OnDetails += () =>
                {
                    var orderForm = new OrderForm(order);
                    orderForm.Changed += () =>
                    {
                        InvalidateCacheAndLoad();
                    };
                    orderForm.ShowDialog();
                };
                card.OnRemove += () =>
                {
                    if (MessageBox.Show("Удалить заказ?", "Удаление заказа",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }

                    try
                    {
                        Program.Context.Order.Remove(order);
                        Program.Context.SaveChanges();
                        MessageBox.Show("Заказ успешно удалён!", "Успех",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InvalidateCacheAndLoad();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Не удалось удалить заказ: {ex.Message}", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    LoadOrders();
                };
                flowLayoutPanel1.Controls.Add(card);
            }
        }
    }
}
