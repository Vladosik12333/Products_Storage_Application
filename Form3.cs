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
    public partial class Form3 : Form
    {
        private List<Product> products = new List<Product>();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;

            if (path != null)
            {
                ReadFile(path);
                GenerateListBox();
            }
        }

        private void ReadFile(string path)
        {
            products.Clear();

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                string dataLine = sr.ReadLine();
                Product product = new Product(dataLine);
                products.Add(product);
            }

            sr.Close();
            fs.Close();
        }

        private void GenerateListBox()
        {
            listBox.Items.Clear();

            for (int i = 0; i < products.Count; i++)
            {
                string parsedProduct = $"{products[i].GetId()}\t{products[i].name}\t{products[i].brand}\t{products[i].price}";
                listBox.Items.Add(parsedProduct);
            }
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
