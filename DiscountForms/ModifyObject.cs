﻿using System;
using System.ComponentModel;
using System.Windows.Forms;
using Discount;
using static DiscountForms.FormTools;

namespace DiscountForms
{
    /// <summary>
    ///     Контрол ModifyObject
    /// </summary>
    public partial class ModifyObject : UserControl
    {
        /// <summary>
        ///     Инициализация ModifyObject
        /// </summary>
        public ModifyObject()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Заблокировать запись в поля
        /// </summary>
        public bool ReadOnly
        {
            set
            {
                PriceBox.ReadOnly = value;
                ValueBox.ReadOnly = value;
                DiscountBox.Enabled = !value;
            }
        }

        /// <summary>
        ///     Вернуть и установить сущность CheckPosition
        /// </summary>
        public CheckPosition CheckPosition
        {
            get
            {
                Discounts discountType;
                if (PercentRadioButton.Checked)
                {
                    discountType = Discounts.Percent;
                }
                else if (CouponRadioButton.Checked)
                {
                    discountType = Discounts.Coupon;
                }
                else
                {
                    //TODO: Программа падает, т.к. не задан выбранный радиобатон по умолчанию
                    throw new ArgumentNullException("Не выбран необходимый тип скидки!");
                }

                return new CheckPosition(DiscountFactory.GetDiscount(discountType,
                    Convert.ToDouble(ValueBox.Text)), new Product(Convert.ToDouble(PriceBox.Text)));
            }
            set
            {
                ValueBox.Text = value.DiscountValue.ToString();
                PriceBox.Text = value.CheckPositionPrice.ToString();
                switch (value.DiscountType)
                {
                    case "Скидка по процентам":
                        PercentRadioButton.Checked = true;
                        break;
                    case "Скидка по купону":
                        CouponRadioButton.Checked = true;
                        break;
                }
            }
        }

        /// <summary>
        ///     Обработчик события валидации DiscountValueBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_Validating(object sender, CancelEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                TextBoxCheck(textBox, e);
            }
        }

        ///// <summary>
        /////     Обработчик события изменения текста в DiscountValueBox
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void ValueBox_TextChanged(object sender, EventArgs e)
        {
            if (PercentRadioButton.Checked)
            {
                try
                {
                    if (Convert.ToDouble(ValueBox.Text) > 100)
                    {
                        ValueBox.Text = "100";
                    }
                }
                catch (FormatException exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}