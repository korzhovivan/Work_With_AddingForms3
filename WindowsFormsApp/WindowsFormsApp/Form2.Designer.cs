namespace WindowsFormsApp
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_NameAdd = new System.Windows.Forms.TextBox();
            this.txtBox_PriceAdd = new System.Windows.Forms.TextBox();
            this.txtBox_DescriptionAdd = new System.Windows.Forms.TextBox();
            this.btn_AddItemToItems = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Description";
            // 
            // txtBox_NameAdd
            // 
            this.txtBox_NameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_NameAdd.Location = new System.Drawing.Point(17, 59);
            this.txtBox_NameAdd.Name = "txtBox_NameAdd";
            this.txtBox_NameAdd.Size = new System.Drawing.Size(150, 29);
            this.txtBox_NameAdd.TabIndex = 10;
            // 
            // txtBox_PriceAdd
            // 
            this.txtBox_PriceAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_PriceAdd.Location = new System.Drawing.Point(17, 141);
            this.txtBox_PriceAdd.Name = "txtBox_PriceAdd";
            this.txtBox_PriceAdd.Size = new System.Drawing.Size(150, 29);
            this.txtBox_PriceAdd.TabIndex = 11;
            // 
            // txtBox_DescriptionAdd
            // 
            this.txtBox_DescriptionAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_DescriptionAdd.Location = new System.Drawing.Point(17, 226);
            this.txtBox_DescriptionAdd.Multiline = true;
            this.txtBox_DescriptionAdd.Name = "txtBox_DescriptionAdd";
            this.txtBox_DescriptionAdd.Size = new System.Drawing.Size(336, 190);
            this.txtBox_DescriptionAdd.TabIndex = 12;
            // 
            // btn_AddItemToItems
            // 
            this.btn_AddItemToItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddItemToItems.Location = new System.Drawing.Point(17, 435);
            this.btn_AddItemToItems.Name = "btn_AddItemToItems";
            this.btn_AddItemToItems.Size = new System.Drawing.Size(169, 33);
            this.btn_AddItemToItems.TabIndex = 13;
            this.btn_AddItemToItems.Text = "Add Item";
            this.btn_AddItemToItems.UseVisualStyleBackColor = true;
            this.btn_AddItemToItems.Click += new System.EventHandler(this.btn_AddItemToItems_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Cancel.Location = new System.Drawing.Point(192, 435);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(161, 33);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 519);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_AddItemToItems);
            this.Controls.Add(this.txtBox_DescriptionAdd);
            this.Controls.Add(this.txtBox_PriceAdd);
            this.Controls.Add(this.txtBox_NameAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_NameAdd;
        private System.Windows.Forms.TextBox txtBox_PriceAdd;
        private System.Windows.Forms.TextBox txtBox_DescriptionAdd;
        private System.Windows.Forms.Button btn_AddItemToItems;
        private System.Windows.Forms.Button btn_Cancel;
    }
}