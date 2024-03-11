using keishi_n_jr;
using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
           Form4 f4= new Form4();
            f4.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7= new Form7();
            f7.Show();
        }
    }
}
