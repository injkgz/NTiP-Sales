﻿using System;

namespace Discount
{
    /// <summary>
    ///     Продукт
    /// </summary>
    [Serializable]
    public class Product
    {
        /// <summary>
        ///     Цена продукта
        /// </summary>
        private double _price;

        /// <summary>
        ///     Конструктор сущности Product
        /// </summary>
        /// <param name="price"></param>
        public Product(double price)
        {
            Price = price;
        }

        /// <summary>
        ///     Вернуть и установить цену товара
        /// </summary>
        public double Price
        {
            get => _price;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Цена не может быть отрицательной!");
                }

                _price = value;
            }
        }
    }
}