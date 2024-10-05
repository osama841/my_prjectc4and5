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
    public partial class Form2 : Form
    {
        int[] a;
        int m = 0, i = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender == txtavg || sender == txtnumstd)
            {
                if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
                    e.Handled = true;
            }
            if (sender == txtname)
            {
                //if ((e.KeyChar >= 65 || e.KeyChar <= 127) && (e.KeyChar != 8))
                //    e.Handled = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtavg.Enabled = txtname.Enabled = button1.Enabled =
           listBox1.Enabled = button1.Enabled = false;
            txtavg.KeyPress += txtname_KeyPress;
            txtnumstd.KeyPress += txtname_KeyPress;
           

        }

        private void txtavg_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtnumstd_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtavg.Text.Trim() != "" && txtname.Text.Trim() != "")
            {
                if (i < m)
                {
                    listBox1.Items.Add(txtname.Text + "\t" + txtavg.Text);
                    a[i++] = int.Parse(txtavg.Text);
                    txtavg.Text = txtname.Text = "";
                    txtavg.Focus(); txtname.Focus();
                }
                else
                {
                    MessageBox.Show("تجاوزت حجم المصفوفة");

                }
            }
            else
            {
                MessageBox.Show("خطاء في النص");
            }
        }

        private void txtnumstd_TextChanged(object sender, EventArgs e)
        {
            {
                txtavg.Enabled = txtname.Enabled = button1.Enabled =
                listBox1.Enabled = button3.Enabled = txtnumstd.Text.Trim() != "";
        }

    }

        private void txtnumstd_MouseLeave(object sender, EventArgs e)
        {
            if (txtnumstd.Text.Trim() != "")
            {
                m = int.Parse(txtnumstd.Text);
                a = new int[m]; i = 0;
            }
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                         int b = listBox1.Items.Count, temp = a[0]; string st = "";
                         if (b > 0)
                         {
                             for (int k = 0; k < i; k++)
                             {
                                 for (int j = k + 1; j < i; j++)
                                 {
                                     if (a[k] > a[j])
                                     {
                                         temp = a[k];
                                         a[k] = a[j];
                                         a[j] = temp;
                                         st = listBox1.Items[k].ToString();
                                         listBox1.Items[k] = listBox1.Items[j].ToString();
                                         listBox1.Items[j] = st.ToString();
                                     }
                                 }

                             }

                         }
                         else
                             MessageBox.Show("القائمه فارغه");
           }
        
     }
}
