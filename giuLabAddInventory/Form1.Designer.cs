﻿namespace giuLabAddInventory
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_inventoryNumber = new System.Windows.Forms.TextBox();
            this.txt_ItemName = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(49, 67);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(156, 26);
            this.txt_name.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_inventoryNumber
            // 
            this.txt_inventoryNumber.Location = new System.Drawing.Point(556, 67);
            this.txt_inventoryNumber.Name = "txt_inventoryNumber";
            this.txt_inventoryNumber.Size = new System.Drawing.Size(197, 26);
            this.txt_inventoryNumber.TabIndex = 2;
            // 
            // txt_ItemName
            // 
            this.txt_ItemName.Location = new System.Drawing.Point(49, 164);
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.Size = new System.Drawing.Size(704, 26);
            this.txt_ItemName.TabIndex = 4;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(238, 257);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(156, 26);
            this.txt_price.TabIndex = 5;
            // 
            // txt_count
            // 
            this.txt_count.Location = new System.Drawing.Point(49, 257);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(156, 26);
            this.txt_count.TabIndex = 6;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(49, 376);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(156, 34);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(238, 376);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(156, 34);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(238, 67);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(281, 26);
            this.dateTimePicker.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(552, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Inventory Number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_ItemName);
            this.Controls.Add(this.txt_inventoryNumber);
            this.Controls.Add(this.txt_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_inventoryNumber;
        private System.Windows.Forms.TextBox txt_ItemName;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

