using System.Collections.Generic;


//namespace DZ_Week2_5
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        int allPrice = 0;
//        public List<Product> prodList = new List<Product>();
//        private void button1_Click(object sender, EventArgs e)
//        {
//            Form2 frm = new Form2();
//            frm.ShowDialog();
//            prodList = frm.productList;
//            frm.Close();

//            foreach (Product prod in prodList)
//            {
//                cb_allProduct.Items.Add(prod.ToString());
//            }
//        }
//        private void button2_Click(object sender, EventArgs e)
//        {
//            if (cb_allProduct.SelectedIndex != -1)
//            {
//                lb_productInCart.Items.Add(prodList[cb_allProduct.SelectedIndex].ToString());
//                allPrice = Int32.Parse(tb_allPrice.Text);
//                tb_allPrice.Text = (allPrice += Int32.Parse(prodList[cb_allProduct.SelectedIndex].Price)).ToString();
//            }

//        }
//    }
//}