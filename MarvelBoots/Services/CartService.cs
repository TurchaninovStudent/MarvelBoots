using System.Collections.Generic;
using System.Linq;
using MarvelBoots.Models;

namespace MarvelBoots.Services
{
    /// <summary>
    /// Сервис для корзины товаров
    /// </summary>
    public static class CartService
    {
        private static readonly List<OrderProduct> Cart = new List<OrderProduct>();

        /// <summary>
        /// Добавить продукт в корзину
        /// </summary>
        public static void AddOrderProduct(OrderProduct product)
            => Cart.Add(product);

        /// <summary>
        /// Удалить продукт из корзины
        /// </summary>
        public static void RemoveOrderProduct(OrderProduct product)
            => Cart.Remove(product);

        /// <summary>
        /// Получить корзину
        /// </summary>
        public static List<OrderProduct> GetAll()
            => Cart;

        /// <summary>
        /// Сформировать полноценный заказ
        /// </summary>
        public static void CreateOrder()
        {
            var order = new Order();

            foreach (var item in Cart)
            {
                item.OrderId = order.IdOrder;
            }

            order.OrderProduct = Cart;

            foreach (var item in Cart)
            {
                foreach (var dbProduct in Program.Context.Product)
                {
                    foreach (var size in dbProduct.ProductSize.Where(x => x.Stock == item.Size))
                    {
                        size.Stock -= item.Amount;
                    }
                }
            }

            Program.Context.Order.Add(order);
            Program.Context.SaveChanges();
        }
    }
}
