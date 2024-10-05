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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < 818; i++)
            //{
            //    button1.Left += 1;
            //}
            //for (int j = 0; j < this.Width - button1.Width; j++)
            //{
            //    button1.Left += 1;

            //    for (int k = 0; k < 1000000; k++) ;
            //}

            //for (int d = 0; d < this.Width / 2; d++)
            //{
            //    button1.Left += 10;
            //    for (int b = 0; b < 1000000; b++) ;
            //}
            //for (int i = 0; i <= this.Width; i++)
            //{
            //    button1.Left += 10;
            //    System.Threading.Thread.Sleep(100);
            //    if (button1.Left > this.Width - button1.Width)
            //    {
            //        break;
            //    }
            //}

            //-----------------------------------------
            //الانشطه
                for (int i = 0; i < 5; i++)
                {
                    button1.Left += 1;

                    for (int j = 0; j < 100;j++ )
                    {
                        button1.Left += 1;

                        for (int k = 0; k < 1000000; k++) ;
                    }
                }

                for (int j = 0; j < 100; j++)
                {
                    button1.Left -= 5;
                    for (int b = 0; b < 10000000; b++) ;
                }

            }
            
        private void button4_Click(object sender, EventArgs e)
        {
            //for (int i = button2.Top; i <= this.Height - button2.Height - 70; i++)
            //{
            //    if (button2.Top > this.Height - button2.Height - 70)
            //    {
            //        break;
            //    }
            //}
            //button2.Top += 10;
            //System.Threading.Thread.Sleep(100);
            //Application.DoEvents();
    //-----------------------------------------
              //الانشطه
            for (int i = 0; i < 5; i++)
            {
                button2.Top += 1;

                for (int j = 0; j < 100; j++)
                {
                    button2.Top += 1;

                    for (int k = 0; k < 1000000; k++) ;
                }
            }
            for (int j = 0; j < 100; j++)
            {
                button2.Top -= 5;
                for (int b = 0; b < 10000000; b++) ;
            }

        }
  
    }
}
