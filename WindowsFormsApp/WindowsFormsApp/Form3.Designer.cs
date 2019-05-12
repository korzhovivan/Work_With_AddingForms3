namespace WindowsFormsApp
{
    partial class Form3
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_EditItem = new System.Windows.Forms.Button();
            this.txtBox_DescriptionEdit = new System.Windows.Forms.TextBox();
            this.txtBox_PriceEdit = new System.Windows.Forms.TextBox();
            this.txtBox_NameEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Cancel.Location = new System.Drawing.Point(192, 437);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(161, 33);
            this.btn_Cancel.TabIndex = 22;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_EditItem
            // 
            this.btn_EditItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_EditItem.Location = new System.Drawing.Point(17, 437);
            this.btn_EditItem.Name = "btn_EditItem";
            this.btn_EditItem.Size = new System.Drawing.Size(169, 33);
            this.btn_EditItem.TabIndex = 21;
            this.btn_EditItem.Text = "Edit Item";
            this.btn_EditItem.UseVisualStyleBackColor = true;
            this.btn_EditItem.Click += new System.EventHandler(this.btn_EditItem_Click);
            // 
            // txtBox_DescriptionEdit
            // 
            this.txtBox_DescriptionEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_DescriptionEdit.Location = new System.Drawing.Point(17, 228);
            this.txtBox_DescriptionEdit.Multiline = true;
            this.txtBox_DescriptionEdit.Name = "txtBox_DescriptionEdit";
            this.txtBox_DescriptionEdit.Size = new System.Drawing.Size(336, 190);
            this.txtBox_DescriptionEdit.TabIndex = 20;
            // 
            // txtBox_PriceEdit
            // 
            this.txtBox_PriceEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_PriceEdit.Location = new System.Drawing.Point(17, 143);
            this.txtBox_PriceEdit.Name = "txtBox_PriceEdit";
            this.txtBox_PriceEdit.Size = new System.Drawing.Size(150, 29);
            this.txtBox_PriceEdit.TabIndex = 19;
            // 
            // txtBox_NameEdit
            // 
            this.txtBox_NameEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_NameEdit.Location = new System.Drawing.Point(17, 61);
            this.txtBox_NameEdit.Name = "txtBox_NameEdit";
            this.txtBox_NameEdit.Size = new System.Drawing.Size(150, 29);
            this.txtBox_NameEdit.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 519);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_EditItem);
            this.Controls.Add(this.txtBox_DescriptionEdit);
            this.Controls.Add(this.txtBox_PriceEdit);
            this.Controls.Add(this.txtBox_NameEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_EditItem;
        private System.Windows.Forms.TextBox txtBox_DescriptionEdit;
        private System.Windows.Forms.TextBox txtBox_PriceEdit;
        private System.Windows.Forms.TextBox txtBox_NameEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}