﻿namespace DiscountForms
{
    partial class AddDialogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new System.Windows.Forms.Button();
            this.AddControl = new DiscountForms.ModifyObject();
            this.ControlObject = new DiscountForms.ModifyObject();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(4, 220);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(145, 40);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // AddControl
            // 
            this.AddControl.DiscountsType = DiscountForms.Discounts.Coupon;
            this.AddControl.DiscountValue = "";
            this.AddControl.Location = new System.Drawing.Point(12, 12);
            this.AddControl.Name = "AddControl";
            this.AddControl.Price = "";
            this.AddControl.Size = new System.Drawing.Size(141, 202);
            this.AddControl.TabIndex = 1;
            // 
            // ControlObject
            // 
            this.ControlObject.DiscountsType = DiscountForms.Discounts.Coupon;
            this.ControlObject.DiscountValue = "";
            this.ControlObject.Location = new System.Drawing.Point(4, 12);
            this.ControlObject.Name = "ControlObject";
            this.ControlObject.Price = "";
            this.ControlObject.Size = new System.Drawing.Size(145, 205);
            this.ControlObject.TabIndex = 1;
            // 
            // AddDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(156, 271);
            this.ControlBox = false;
            this.Controls.Add(this.ControlObject);
            this.Controls.Add(this.buttonAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddDialogForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление товара";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private ModifyObject AddControl;
        private ModifyObject ControlObject;
    }
}