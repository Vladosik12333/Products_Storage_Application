using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _64632_Vladyslav_Babiak_task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void writeBtn_Click(object sender, EventArgs e)
        {
            this.idOutput.Text = "?";

            Product product = CreateProduct();
            SaveData(product);

            this.idOutput.Text = product.GetId();
            ClearBoxes();
        }

        private void ClearBoxes()
        {
            this.nameBox.Clear();
            this.brandBox.Clear();
            this.priceBox.Clear();
        }

        private Product CreateProduct ()
        {
            string name = this.nameBox.Text;
            string brand = this.brandBox.Text;
            float price = Convert.ToSingle(this.priceBox.Text);

            Product product = new Product(name, brand, price);

            return product;
        }

        private void SaveData (Product product)
        {
            FileStream fs = new FileStream("products.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(product.GenerateData());

            sw.Close();
            fs.Close();
        }

        private void backMenuBtn_Click(object sender, EventArgs e)
        {
            Form2 menuForm = new Form2();
            this.Hide();
            menuForm.ShowDialog();
            this.Close();
        }
    }
}
