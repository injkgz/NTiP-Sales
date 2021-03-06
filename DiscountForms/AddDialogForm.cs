﻿using System;
using System.Windows.Forms;
using Discount;

namespace DiscountForms
{
    public partial class AddDialogForm : Form
    {
        /// <summary>
        ///     Конструктор формы Dialog
        /// </summary>
        public AddDialogForm()
        {
            InitializeComponent();
            ObjectControl.ReadOnly = false;
        }

        /// <summary>
        ///     Вернуть и установить сущность CheckPosition
        /// </summary>
        public CheckPosition Object
        {
            get
            {
                CheckPosition checkPosition = null;
                try
                {
                    checkPosition = ObjectControl.CheckPosition;
                }
                catch (ArgumentException e)
                {
                    MessageBox.Show(e.Message);
                }

                return checkPosition;
            }
            set
            {
                try
                {
                    ObjectControl.CheckPosition = value;
                }
                catch (ArgumentException e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        /// <summary>
        ///     Обработчик события нажатия на кнопку Добавить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (Object != null)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}