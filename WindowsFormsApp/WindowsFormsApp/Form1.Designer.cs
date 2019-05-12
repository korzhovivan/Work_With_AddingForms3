namespace WindowsFormsApp
{
    partial class Form1
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
            this.listBox_Cart = new System.Windows.Forms.ListBox();
            this.comboBox_Items = new System.Windows.Forms.ComboBox();
            this.txtBox_Price = new System.Windows.Forms.TextBox();
            this.btn_AddToCart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddItem = new System.Windows.Forms.Button();
            this.lbl_AllPrice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Cart
            // 
            this.listBox_Cart.FormattingEnabled = true;
            this.listBox_Cart.Location = new System.Drawing.Point(25, 155);
            this.listBox_Cart.Name = "listBox_Cart";
            this.listBox_Cart.Size = new System.Drawing.Size(279, 238);
            this.listBox_Cart.TabIndex = 0;
            // 
            // comboBox_Items
            // 
            this.comboBox_Items.FormattingEnabled = true;
            this.comboBox_Items.Location = new System.Drawing.Point(25, 27);
            this.comboBox_Items.Name = "comboBox_Items";
            this.comboBox_Items.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Items.TabIndex = 1;
            // 
            // txtBox_Price
            // 
            this.txtBox_Price.Enabled = false;
            this.txtBox_Price.Location = new System.Drawing.Point(152, 28);
            this.txtBox_Price.Name = "txtBox_Price";
            this.txtBox_Price.Size = new System.Drawing.Size(62, 20);
            this.txtBox_Price.TabIndex = 2;
            // 
            // btn_AddToCart
            // 
            this.btn_AddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddToCart.Location = new System.Drawing.Point(26, 64);
            this.btn_AddToCart.Name = "btn_AddToCart";
            this.btn_AddToCart.Size = new System.Drawing.Size(120, 33);
            this.btn_AddToCart.TabIndex = 3;
            this.btn_AddToCart.Text = "Add to card";
            this.btn_AddToCart.UseVisualStyleBackColor = true;
            this.btn_AddToCart.Click += new System.EventHandler(this.btn_AddToCart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(220, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "грн.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Корзина";
            // 
            // btn_AddItem
            // 
            this.btn_AddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddItem.Location = new System.Drawing.Point(266, 64);
            this.btn_AddItem.Name = "btn_AddItem";
            this.btn_AddItem.Size = new System.Drawing.Size(178, 33);
            this.btn_AddItem.TabIndex = 7;
            this.btn_AddItem.Text = "Add item";
            this.btn_AddItem.UseVisualStyleBackColor = true;
            this.btn_AddItem.Click += new System.EventHandler(this.btn_AddItem_Click);
            // 
            // lbl_AllPrice
            // 
            this.lbl_AllPrice.AutoSize = true;
            this.lbl_AllPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_AllPrice.Location = new System.Drawing.Point(20, 411);
            this.lbl_AllPrice.Name = "lbl_AllPrice";
            this.lbl_AllPrice.Size = new System.Drawing.Size(0, 31);
            this.lbl_AllPrice.TabIndex = 8;
            this.lbl_AllPrice.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(266, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Edit item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 464);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_AllPrice);
            this.Controls.Add(this.btn_AddItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AddToCart);
            this.Controls.Add(this.txtBox_Price);
            this.Controls.Add(this.comboBox_Items);
            this.Controls.Add(this.listBox_Cart);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Cart;
        private System.Windows.Forms.ComboBox comboBox_Items;
        private System.Windows.Forms.TextBox txtBox_Price;
        private System.Windows.Forms.Button btn_AddToCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AddItem;
        private System.Windows.Forms.Label lbl_AllPrice;
        private System.Windows.Forms.Button button1;
    }
}

