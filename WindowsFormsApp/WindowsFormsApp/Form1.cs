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
    

    public partial class Form1 : Form
    {
        List<Item> items = new List<Item>() {
                new Item("Ryzen 5 ", 2300, "Processor and blablabla"),
                new Item("Intel 3 ", 1450, "Processor and blablabla"),
                new Item("Intel 5 ", 5300, "Processor and blablabla"),
                new Item("Ryzen 3", 2500, "Processor and blablabla"),
                new Item("Intel 7", 6500, "Processor and blablabla")
        };
        List<Item> itemsInCard = new List<Item>();
        double allPrice = 0;

        public Form1()
        {
            
            InitializeComponent();
            foreach (Item item in items)
            {
                comboBox_Items.Items.Add(item.Name);
            }

            comboBox_Items.SelectedIndexChanged += ComboBox_Items_SelectedIndexChanged;
            listBox_Cart.SelectedIndexChanged += ListBox_Cart_SelectedIndexChanged;
        }

        private void ListBox_Cart_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Description: "+ itemsInCard[listBox_Cart.SelectedIndex].Description);
        }

        private void ComboBox_Items_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBox_Price.Text = Convert.ToString(items[comboBox_Items.SelectedIndex].Price);
        }

        private void btn_AddToCart_Click(object sender, EventArgs e)
        {
            lbl_AllPrice.Visible = true;
            string info = items[comboBox_Items.SelectedIndex].Name + "  (" + Convert.ToString(items[comboBox_Items.SelectedIndex].Price) + " uan.)";
            listBox_Cart.Items.Add(info);
            allPrice += items[comboBox_Items.SelectedIndex].Price;
            lbl_AllPrice.Text ="All Price: " +allPrice.ToString() + " uan.";
            itemsInCard.Add(items[comboBox_Items.SelectedIndex]);
        }

        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            Form2 addItem = new Form2();
            if (addItem.ShowDialog() == DialogResult.OK)
            {
                items.Add(addItem.NewItemInfo);
                comboBox_Items.Items.Add(addItem.NewItemInfo.Name);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 editForm = new Form3(items[comboBox_Items.SelectedIndex]);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                items[comboBox_Items.SelectedIndex] = editForm.NewItemInfo;
            }
           
        }
    }
    
}
