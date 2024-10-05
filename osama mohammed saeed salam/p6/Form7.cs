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
    // فوزم النشاط 
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // إخفاء اللوحة
            panel1.Visible = false;
            panel1.Location = new Point(2, 100);
            //  ربط جميع الأزرار بحدث واحد
            button1.Click += button4_Click;
            button2.Click += button4_Click;
            button3.Click += button4_Click;
            button5.Click += button4_Click;
            textBox1.KeyPress += OnlyAllowNumbers_KeyPress;
            textBox2.KeyPress += OnlyAllowNumbers_KeyPress;
            // ربط جميع مربعات النصوص بحدث KeyPress واحد
        }
        // دالة للتأكد من أن المستخدم يدخل أرقام فقط في مربعات النصوص
        private void OnlyAllowNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            // السماح فقط بالأرقام أو زر الحذف (Backspace)
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
                e.Handled = true; // تجاهل الحرف إذا لم يكن رقماً أو Backspace
        }
        // حدث واحد لجميع الأزرار
        private void button4_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            //// إظهار اللوحة
            panel1.Visible = true;
            ////  استدعاء العملية بناءً على الزر المضغوط
            switch (clickedButton.Name)
            {
                case "button4": // زر الجمع
                    label4.Text = "+";
                    break;
                case "button3": // زر الطرح
                    label4.Text = "-";
                    break;
                case "button2": // زر الضرب
                    label4.Text = "*";
                    break;
                case "button1": // زر القسمة
                    label4.Text = "/";
                    break;
            }
        }  
        private void button5_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(textBox1.Text);
            int number2 = Convert.ToInt32(textBox2.Text);
            int result = 0; // متغير لتخزين النتيجة

            // تحديد العملية الحسابية بناءً على النوع
            switch (label4.Text)
            {
                case "+":
                    result = number1 + number2; // عملية الجمع
                    break;
                case "-":
                    result = number1 - number2; // عملية الطرح
                    break;
                case "*":
                    result = number1 * number2; // عملية الضرب
                    break;
                case "/": if (number2 != 0) result = number1 / number2;
                    // التأكد من أن المقسوم عليه ليس صفر               
                    else
                        MessageBox.Show("التأكد من أن المقسوم عليه ليس صفر");
                    break;
            }
            textBox3.Text = result.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7_Load(null, null);
        }

    }
}


