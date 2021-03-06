﻿using System;
using System.ComponentModel;
using System.Windows.Forms;
using Discount;
using DiscountForms.Properties;
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
            CouponRadioButton.Checked = true;
        }

        /// <summary>
        ///     Установить/вернуть разрешение на запись в поля
        /// </summary>
        public bool ReadOnly
        {
            set
            {
                PriceBox.ReadOnly = value;
                ValueBox.ReadOnly = value;
                DiscountBox.Enabled = !value;
            }
            get
            {
                if (PriceBox.ReadOnly && ValueBox.ReadOnly && DiscountBox.Enabled)
                {
                    return true;
                }

                return false;
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
                    throw new ArgumentException("Не выбран необходимый тип скидки!");
                }

                if (PriceBox.Text != string.Empty && ValueBox.Text != string.Empty)
                {
                    return new CheckPosition(DiscountFactory.GetDiscount(discountType,
                        Convert.ToDouble(ValueBox.Text)), new Product(Convert.ToDouble(PriceBox.Text)));
                }

                throw new ArgumentException("Заполните все поля!");
            }
            set
            {
                switch (value.DiscountType)
                {
                    case "Скидка по процентам":
                        PercentRadioButton.Checked = true;
                        break;
                    case "Скидка по купону":
                        CouponRadioButton.Checked = true;
                        break;
                }

                ValueBox.Text = value.DiscountValue.ToString();
                PriceBox.Text = value.CheckPositionPrice.ToString();
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
        /////     Обработчик события изменения текста в TextBox
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (textBox.Text == "")
                {
                }
                else
                {
                    try
                    {
                        Convert.ToDouble(textBox.Text);
                        if (!ReadOnly)
                        {
                            if (!PercentRadioButton.Checked)
                            {
                                return;
                            }

                            if (Convert.ToDouble(ValueBox.Text) > 100)
                            {
                                ValueBox.Text = Resources.PercentMaxValue;
                            }
                        }
                    }
                    catch (FormatException exception)
                    {
                        MessageBox.Show("Вы вводите некорректные символы!\n" + exception.Message);
                    }
                }
            }
        }
    }
}