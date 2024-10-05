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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opn = new OpenFileDialog())
            {
               
                // السماح فقط بأنواع معينة من الملفات (مثل الصور)
                opn.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                // فتح مربع الحوار واختيار الملف
                if (opn.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // محاولة تحميل الصورة
                        string file = opn.FileName;
                        Bitmap temp = new Bitmap(file);

                        // تعيين الصورة كخلفية لـ pictureBox1
                        pictureBox1.BackgroundImage = temp;
                        pictureBox1.BackgroundImageLayout = ImageLayout.Zoom; // لضبط الصورة داخل الـ PictureBox
                    }
                    catch (Exception ex)
                    {
                        // في حال حدوث خطأ أثناء تحميل الصورة
                        MessageBox.Show("حدث خطأ أثناء تحميل الصورة: " + ex.Message);
                    }
                }
            }
        }
               

            //OpenFileDialog opn = new OpenFileDialog();
            //opn.ShowDialog();
            //string file = opn.FileName;
            //Bitmap temp = new Bitmap(file);
            //pictureBox1.BackgroundImage = temp;
            //int i = 1;
            //string str = "d:\\" + i.ToString() + ".jpg";
            //Bitmap temp = new Bitmap(str);
            //pictureBox1.BackgroundImage=temp;
        }
    }

