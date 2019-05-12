using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form3 : Form
    {
        private Item newItemInfo = null;

        internal Item NewItemInfo { get => newItemInfo; set => newItemInfo = value; }

        public Form3(Item item)
        {
            InitializeComponent();
            txtBox_NameEdit.Text = item.Name;
            txtBox_PriceEdit.Text = item.Price.ToString();
            txtBox_DescriptionEdit.Text = item.Description;
        }

        private void btn_EditItem_Click(object sender, EventArgs e)
        {
            NewItemInfo = new Item(txtBox_NameEdit.Text, Convert.ToInt32(txtBox_PriceEdit.Text), txtBox_DescriptionEdit.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
