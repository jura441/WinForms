using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//namespace DZ_Week2_5
//{
//    public partial class Form2 : Form
//    {
//        public Form2()
//        {
//            InitializeComponent();
//        }
//        public List<Product> productList = new List<Product>();


//        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }
//        private void btn_addItemCollection_Click(object sender, EventArgs e)
//        {
//            Product curProd = new Product();
//            curProd.Name = tb_name.Text;
//            curProd.Characters = tb_characteristics.Text;
//            curProd.Desc = tb_description.Text;
//            curProd.Price = tb_price.Text;
//            productList.Add(curProd);
//            listBox1.Items.Add(curProd.ToString());
//        }

//        private void btn_editItemCollection_Click(object sender, EventArgs e)
//        {
//            string[] strings = ((string)listBox1.Items[listBox1.SelectedIndex]).Split(" ");
//            tb_characteristics.Text = strings[1];
//            tb_name.Text = strings[0];
//            tb_description.Text = strings[2];
//            foreach (Product str in productList)
//            {
//                if (str.Name == tb_name.Text && str.Characters == tb_characteristics.Text && str.Desc == tb_description.Text)
//                {
//                    tb_price.Text = str.Price;
//                }
//            }
//        }

//        private void btn_closeForm_Click(object sender, EventArgs e)
//        {
//            this.Close();
//        }

//        private void btn_saveItemsCollection_Click(object sender, EventArgs e)
//        {
//            if (listBox1.SelectedIndex != -1)
//            {
//                productList[listBox1.SelectedIndex].Name = tb_name.Text;
//                productList[listBox1.SelectedIndex].Characters = tb_characteristics.Text;
//                productList[listBox1.SelectedIndex].Desc = tb_description.Text;
//                productList[listBox1.SelectedIndex].Price = tb_price.Text;
//                listBox1.Items[listBox1.SelectedIndex] = productList[listBox1.SelectedIndex].ToString();
//            }
//        }

//        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            if (tb_description.Text.Length == 0 && tb_name.Text.Length == 0 && tb_characteristics.Text.Length == 0 && tb_price.Text.Length == 0)
//            {
//                string[] strings = ((string)listBox1.Items[listBox1.SelectedIndex]).Split(" ");
//                tb_characteristics.Text = strings[1];
//                tb_name.Text = strings[0];
//                tb_description.Text = strings[2];
//                foreach (Product str in productList)
//                {
//                    if (str.Name == tb_name.Text && str.Characters == tb_characteristics.Text && str.Desc == tb_description.Text)
//                    {
//                        tb_price.Text = str.Price;
//                    }
//                }
//            }
//        }

//        private void Form2_Load(object sender, EventArgs e)
//        {

//        }

//        private void button1_Click(object sender, EventArgs e)
//        {

//        }

//        private void textBox4_TextChanged(object sender, EventArgs e)
//        {

//        }
//    }
//}
