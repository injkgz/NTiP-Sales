﻿namespace DiscountForms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.productTable = new System.Windows.Forms.DataGridView();
            this.checkPositionPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkPositionDiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkPositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAdd = new System.Windows.Forms.Button();
            this.bindingSourceCheckPosition = new System.Windows.Forms.BindingSource(this.components);
            this.deleteButton = new System.Windows.Forms.Button();
            this.buttonAddRandom = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.ShowObject = new DiscountForms.ModifyObject();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPositionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCheckPosition)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productTable
            // 
            this.productTable.AllowUserToAddRows = false;
            this.productTable.AllowUserToDeleteRows = false;
            this.productTable.AutoGenerateColumns = false;
            this.productTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkPositionPriceDataGridViewTextBoxColumn,
            this.discountTypeDataGridViewTextBoxColumn,
            this.discountValueDataGridViewTextBoxColumn,
            this.checkPositionDiscountDataGridViewTextBoxColumn});
            this.productTable.DataSource = this.checkPositionBindingSource;
            this.productTable.Location = new System.Drawing.Point(12, 28);
            this.productTable.Name = "productTable";
            this.productTable.ReadOnly = true;
            this.productTable.Size = new System.Drawing.Size(599, 423);
            this.productTable.TabIndex = 0;
            this.productTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductTable_CellClick);
            this.productTable.SelectionChanged += new System.EventHandler(this.productTable_SelectionChanged);
            // 
            // checkPositionPriceDataGridViewTextBoxColumn
            // 
            this.checkPositionPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.checkPositionPriceDataGridViewTextBoxColumn.DataPropertyName = "CheckPositionPrice";
            this.checkPositionPriceDataGridViewTextBoxColumn.HeaderText = "Цена товара";
            this.checkPositionPriceDataGridViewTextBoxColumn.Name = "checkPositionPriceDataGridViewTextBoxColumn";
            this.checkPositionPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.checkPositionPriceDataGridViewTextBoxColumn.Width = 96;
            // 
            // discountTypeDataGridViewTextBoxColumn
            // 
            this.discountTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.discountTypeDataGridViewTextBoxColumn.DataPropertyName = "DiscountType";
            this.discountTypeDataGridViewTextBoxColumn.HeaderText = "Тип скидки";
            this.discountTypeDataGridViewTextBoxColumn.Name = "discountTypeDataGridViewTextBoxColumn";
            this.discountTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.discountTypeDataGridViewTextBoxColumn.Width = 90;
            // 
            // discountValueDataGridViewTextBoxColumn
            // 
            this.discountValueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.discountValueDataGridViewTextBoxColumn.DataPropertyName = "DiscountValue";
            this.discountValueDataGridViewTextBoxColumn.HeaderText = "Значение скидки";
            this.discountValueDataGridViewTextBoxColumn.Name = "discountValueDataGridViewTextBoxColumn";
            this.discountValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.discountValueDataGridViewTextBoxColumn.Width = 109;
            // 
            // checkPositionDiscountDataGridViewTextBoxColumn
            // 
            this.checkPositionDiscountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.checkPositionDiscountDataGridViewTextBoxColumn.DataPropertyName = "CheckPositionDiscount";
            this.checkPositionDiscountDataGridViewTextBoxColumn.HeaderText = "Итоговая цена";
            this.checkPositionDiscountDataGridViewTextBoxColumn.Name = "checkPositionDiscountDataGridViewTextBoxColumn";
            this.checkPositionDiscountDataGridViewTextBoxColumn.ReadOnly = true;
            this.checkPositionDiscountDataGridViewTextBoxColumn.Width = 98;
            // 
            // checkPositionBindingSource
            // 
            this.checkPositionBindingSource.DataSource = typeof(Discount.CheckPosition);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(620, 386);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(113, 30);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAddProduct_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(621, 422);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(112, 29);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // buttonAddRandom
            // 
            this.buttonAddRandom.Location = new System.Drawing.Point(617, 28);
            this.buttonAddRandom.Name = "buttonAddRandom";
            this.buttonAddRandom.Size = new System.Drawing.Size(116, 41);
            this.buttonAddRandom.TabIndex = 3;
            this.buttonAddRandom.Text = "RANDOM";
            this.buttonAddRandom.UseVisualStyleBackColor = true;
            this.buttonAddRandom.Click += new System.EventHandler(this.ButtonAddRandom_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(753, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveMenuItem,
            this.LoadMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Size = new System.Drawing.Size(132, 22);
            this.SaveMenuItem.Text = "Сохранить";
            this.SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // LoadMenuItem
            // 
            this.LoadMenuItem.Name = "LoadMenuItem";
            this.LoadMenuItem.Size = new System.Drawing.Size(132, 22);
            this.LoadMenuItem.Text = "Загрузить";
            this.LoadMenuItem.Click += new System.EventHandler(this.LoadMenuItem_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(617, 84);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(116, 20);
            this.searchBox.TabIndex = 5;
            this.searchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            this.searchBox.Validating += new System.ComponentModel.CancelEventHandler(this.SearchBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(617, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите цену товара:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(617, 110);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(116, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(620, 350);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(112, 30);
            this.ModifyButton.TabIndex = 9;
            this.ModifyButton.Text = "Изменить";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // ShowObject
            // 
            this.ShowObject.Location = new System.Drawing.Point(617, 139);
            this.ShowObject.Name = "ShowObject";
            this.ShowObject.Size = new System.Drawing.Size(132, 205);
            this.ShowObject.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 461);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.ShowObject);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.buttonAddRandom);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.productTable);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Расчёт скидок";
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPositionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCheckPosition)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productTable;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.BindingSource bindingSourceCheckPosition;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.BindingSource checkPositionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkPositionPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkPositionDiscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonAddRandom;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadMenuItem;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private ModifyObject ShowObject;
        private System.Windows.Forms.Button ModifyButton;
    }
}

