using System;
using System.Collections.Generic;
using System.Linq;
using MarvelBoots.Models;

namespace MarvelBoots.Services
{
    /// <summary>
    /// Сервис для цены продукта
    /// </summary>
    public static class ProductPriceService
    {
        private static readonly List<Order> OrdersInApril
            = Program.Context.Order.Where(x => DateTime.Now.Year == x.Date.Year && x.Date.Month == 4).ToList();

        /// <summary>
        /// Получить цену с учётом скидки 25%
        /// </summary>
        public static decimal GetPrice(Product product)
            => OrdersInApril
            .Any(x => x.OrderProduct.Where(y => y.ProductId == product.IdProduct).Any())
                ? product.Price * (decimal)0.75 : product.Price;
    }
}
