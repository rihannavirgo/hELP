using _2ndpage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keishi_n_jr
{
    public partial class Form3 : Form
    {
        private bool isButton = false;
        public Form3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {




        }

        private void button18_Click(object sender, EventArgs e)
        {
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isButton)
                button4.BackColor = Color.Coral;

            else
                button4.BackColor = Color.Crimson;
            isButton = !isButton;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isButton)
                button1.BackColor = Color.Coral;

            else
                button1.BackColor = Color.Crimson;
            isButton = !isButton;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isButton)
                button6.BackColor = Color.Coral;

            else
                button6.BackColor = Color.Crimson;
            isButton = !isButton;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (isButton)
                button11.BackColor = Color.Coral;

            else
                button11.BackColor = Color.Crimson;
            isButton = !isButton;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (isButton)
                button13.BackColor = Color.Coral;

            else
                button13.BackColor = Color.Crimson;
            isButton = !isButton;
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            if (isButton)
                button18.BackColor = Color.Coral;

            else
                button18.BackColor = Color.Crimson;
            isButton = !isButton;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (isButton)
                button16.BackColor = Color.Coral;

            else
                button16.BackColor = Color.Crimson;
            isButton = !isButton;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (isButton)
                button14.BackColor = Color.Coral;

            else
                button14.BackColor = Color.Crimson;
            isButton = !isButton;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (isButton)
                button12.BackColor = Color.Coral;

            else
                button12.BackColor = Color.Crimson;
            isButton = !isButton;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isButton)
                button9.BackColor = Color.Coral;

            else
                button9.BackColor = Color.Crimson;
            isButton = !isButton;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (isButton)
                button7.BackColor = Color.Coral;

            else
                button7.BackColor = Color.Crimson;
            isButton = !isButton;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isButton)
                button5.BackColor = Color.Coral;

            else
                button5.BackColor = Color.Crimson;
            isButton = !isButton;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isButton)
                button3.BackColor = Color.Coral;

            else
                button3.BackColor = Color.Crimson;
            isButton = !isButton;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2= new Form2();
            f2.Show();
        }
    }
}
