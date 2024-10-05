using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p6
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = 0; bool f = false;
            if (checkBox1.Checked)
            {
                s += Convert.ToInt32(checkBox1.Text); 
                f = true;
            }
            if (checkBox2.Checked)
            {
                s += Convert.ToInt32(checkBox2.Text); f = true;
            }
            if (checkBox3.Checked)
            {
                s += Convert.ToInt32(checkBox3.Text); f = true;
            }
            if (checkBox4.Checked)
            {
                s += Convert.ToInt32(checkBox4.Text); f = true;
            }
            if (checkBox5.Checked)
            {
                s += Convert.ToInt32(checkBox5.Text); f = true;
            }
            if (f)
                textBox1.Text = s.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {  
            {
                if (radioButton1.Checked)
                    label16.ForeColor = Color.Red;   
                else if (radioButton2.Checked)
                      label9.BackColor = Color.Yellow;
                else if (radioButton3.Checked)
                    label8.ForeColor = Color.Green;
                else if (radioButton4.Checked)
                    label7.BackColor = Color.Black; 
                //-------------------------------
                if (radioButton1.Checked)
                    label16.ForeColor = Color.Red;
                else if (radioButton2.Checked)
                    label16.BackColor = Color.Yellow;
                else if (radioButton3.Checked)
                    label16.ForeColor = Color.Green;
                else if (radioButton4.Checked)
                    label16.BackColor = Color.Black; 

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
        }
    }
}
