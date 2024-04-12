using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _64632_Vladyslav_Babiak_task_3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void writeBtn_Click(object sender, EventArgs e)
        {
            Form1 writeForm = new Form1();
            this.Hide();
            writeForm.ShowDialog();
            this.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            Form3 readForm = new Form3();
            this.Hide();
            readForm.ShowDialog();
            this.Close();
        }
    }
}
