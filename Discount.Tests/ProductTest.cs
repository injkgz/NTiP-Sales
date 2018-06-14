﻿using System;
using NUnit.Framework;

namespace Discount.Tests
{
    [TestFixture]
    public class ProductTest
    {
        /// <summary>
        ///     Положительный тест конструктора сущности Product
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Test]
        [TestCase(1, ExpectedResult = 1, TestName = "Проверка " +
                                                    "присваивания минимального логического значения")]
        [TestCase(99999, ExpectedResult = 99999, TestName = "Проверка " +
                                                            "присваивания рандомных значений")]
        [TestCase(1.5, ExpectedResult = 1.5, TestName = "Проверка " +
                                                        "присваивания рандомных значений")]
        public double ProductConstructorTest(double value)
        {
            var product = new Product(value);
            return product.Price;
        }

        /// <summary>
        ///     Негативный тест конструктора сущности Product
        /// </summary>
        /// <param name="value"></param>
        [Test]
        [TestCase(0, TestName = "Проверка присваивания 0")]
        [TestCase(-1, TestName = "Проверка присваивания отрицательного значения")]
        public void ProductConstructorThrows(double value)
        {
            Assert.That(() => new Product(value), Throws.TypeOf<Exception>());
        }
    }
}