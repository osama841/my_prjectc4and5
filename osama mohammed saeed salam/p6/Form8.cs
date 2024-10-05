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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int index=textBox1.Text.IndexOf(textBox4.Text);
           if (index != -1)
           {
               textBox1.Select(index, textBox4.Text.Length);
               textBox1.Focus();
           }
           else
           {
               MessageBox.Show("not fond");
           }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            textBox2.Text = str.ToUpper();
            textBox3.Text = str.Length.ToString();
             char []ch =new char[str.Length];
            listBox1.Items.Clear();

            for (int i = 0; i < str.Length; i++)
            {
                listBox1.Items.Add(ch[i]);
                string[] arstr = textBox1.Text.Split(' ');
                listBox2.Items.Clear();

                for (int j = 0; j < arstr.Count(); j++) 
                {
                    listBox1.Items.Add(arstr[j]);
                    textBox5.Text = listBox2.Items.Count.ToString();

                }

            }

        }
    }
}
