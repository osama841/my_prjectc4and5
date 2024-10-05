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
    public partial class Form1 : Form
    {
        string[] a;
        int m = 0, i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = button1.Enabled = button2.Enabled
           = button3.Enabled = listBox1.Enabled = textBox3.Enabled = false;
            a = new string[m];  // تهيئة المصفوفة بالحجم الجديد
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                if (i < m) // التحقق من عدم تجاوز حجم المصفوفة
                {
                    a[i++] = textBox1.Text.ToString();  // إدخال القيمة في المصفوفة
                    textBox1.Clear();
                    textBox1.Focus();
                }
                else
                {
                    MessageBox.Show("تم تجاوز الحد الأقصى لحجم المصفوفة");
                    textBox1.Clear();
                }
            }
            else
            {
                MessageBox.Show("الرجاء إدخال قيمة صحيحة.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // التحقق من أن المصفوفة قد تم تهيئتها
            if (a == null)
            {
                MessageBox.Show("الرجاء تحديد حجم المصفوفة أولاً.");
                return;
            }

            listBox1.Items.Clear();  // مسح العناصر الحالية في الـ ListBox

            if (i > 0) // التحقق من أن هناك قيمًا مدخلة في المصفوفة
            {
                for (int h = 0; h < i; h++)
                {
                    listBox1.Items.Add(a[h]);  // عرض القيم المدخلة في الـ ListBox
                }
            }
            else
            {
                MessageBox.Show("المصفوفة فارغة حالياً.");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (listBox1.Items.Count > 0)
            {
                for (int h = 0; h < i; h++)
                {
                    s += int.Parse(a[h]);
                }
                textBox3.Text = s.ToString();
            }
            else
            {
                MessageBox.Show("القائمة فارغة");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            bool f = (textBox2.Text != "");
            textBox1.Enabled = button1.Enabled = button2.Enabled
                = button3.Enabled = listBox1.Enabled = textBox3.Enabled = f;

            if (f)
            {
                m = int.Parse(textBox2.Text);
                a = new string[m];
            }
            listBox1.Items.Clear();
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.Clear();
                i = m = 0;
                a = new string[0];
                textBox1.Text = textBox2.Text = textBox3.Text = "";
            }
            else
            {
                MessageBox.Show("القائمة فارغة");
            }
        }

    }
}
    

