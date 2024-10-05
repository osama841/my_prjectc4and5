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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            panel1.Visible = panel2.Visible = panel3.Visible = panel4.Visible = false;
            panel1.Location = panel2.Location = panel3.Location = panel4.Location = new Point(1, 60);

            // ربط جميع الأزرار بحدث واحد
            button12.Click += button8_Click;
            button10.Click += button8_Click;
            button5.Click += button8_Click;
            // ربط جميع مربعات النصوص بحدث KeyPress واحد
            textBox2.KeyPress += textBox1_KeyPress;
            textBox3.KeyPress += textBox1_KeyPress;
            textBox4.KeyPress += textBox1_KeyPress;
            textBox5.KeyPress += textBox1_KeyPress;
            textBox6.KeyPress += textBox1_KeyPress;
            textBox7.KeyPress += textBox1_KeyPress;
            textBox8.KeyPress += textBox1_KeyPress;
            textBox9.KeyPress += textBox1_KeyPress;
            textBox10.KeyPress += textBox1_KeyPress;
            textBox11.KeyPress += textBox1_KeyPress;
            textBox12.KeyPress += textBox1_KeyPress;
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar !=8))
                e.Handled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel2.Visible = false;
            panel1.Visible = false;
            panel4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel1.Visible = false;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if ((textBox6.Text.Trim()!= "") && (textBox5.Text.Trim() != ""))
            {
                textBox4.Text = Convert.ToString(Convert.ToInt32(textBox6.Text) -
             Convert.ToInt32(textBox5.Text));
            }
            else
                MessageBox.Show("ادخل رقما");
        }

        private void button5_Click(object sender, EventArgs e)
        {
              if ((textBox6.Text.Trim() != "" )&& (textBox5.Text.Trim() != ""))
            {
            textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) +
            Convert.ToInt32(textBox2.Text));
                  }
              else
              MessageBox.Show("ادخل رقما");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if ((textBox9.Text.Trim() != "") && (textBox8.Text.Trim() != ""))
            {
                if(textBox9.Text!="0")
                textBox7.Text = Convert.ToString(Convert.ToInt32(textBox9.Text) /
                Convert.ToInt32(textBox8.Text));
            }
            else
                MessageBox.Show("ادخل رقما");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if ((textBox12.Text.Trim() != "") && (textBox11.Text.Trim() != ""))
            {
                textBox10.Text = Convert.ToString(Convert.ToInt32(textBox12.Text) *
                Convert.ToInt32(textBox11.Text));
            }
            else
                MessageBox.Show("ادخل رقما");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form6_Load(null, null);
        }

       
    }
}
