using System;
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
            var order = new Order
            {
                Date = DateTime.Now,
                UserId = IdentityService.User.IdUser,
                OrderProduct = Cart.Select(item => new OrderProduct
                {
                    ProductId = item.ProductId,
                    CategoryId = item.CategoryId,
                    ManufacturerId = item.ManufacturerId,
                    Amount = item.Amount,
                    Size = item.Size,
                    PricePerUnit = item.PricePerUnit
                }).ToList()
            };

            var productIdsInCart = Cart.Select(x => x.ProductId).Distinct().ToList();

            var dbProducts = Program.Context.Product
                .Where(p => productIdsInCart.Contains(p.IdProduct))
                .ToList();

            foreach (var cartItem in Cart)
            {
                var dbProduct = dbProducts.FirstOrDefault(p => p.IdProduct == cartItem.ProductId);
                if (dbProduct != null)
                {
                    var targetSize = dbProduct.ProductSize.FirstOrDefault(x => x.Size == cartItem.Size);

                    if (targetSize != null)
                    {
                        if (targetSize.Stock < cartItem.Amount)
                            throw new Exception($"Недостаточно товара с размером {cartItem.Size} на складе!");

                        targetSize.Stock -= cartItem.Amount;
                    }
                }
            }

            Cart.Clear();
            Program.Context.Order.Add(order);
            Program.Context.SaveChanges();
        }
    }
}
