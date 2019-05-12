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
    public partial class Form2 : Form
    {
        private Item newItemInfo = null;

        internal Item NewItemInfo { get => newItemInfo; set => newItemInfo = value; }

        public Form2()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_AddItemToItems_Click(object sender, EventArgs e)
        {
            NewItemInfo = new Item(txtBox_NameAdd.Text, Convert.ToInt32(txtBox_PriceAdd.Text) ,txtBox_DescriptionAdd.Text);
            this.DialogResult = DialogResult.OK;
        }
    }
}
