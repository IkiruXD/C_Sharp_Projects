using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

       double a, b;
        int count;
        bool znak = true;

        public Form1()
        {
            InitializeComponent();
        }

        //******************************************************
        //для глупеньких
        //******************************************************
        private void button_т_умножить_Click(object sender, EventArgs e)
        {
            label3.Text = "Результат: " + Convert.ToString(Umnozhenie(Convert.ToDouble(textBox_т_число1.Text), Convert.ToDouble(textBox_т_число2.Text)));
        }

        private void button_т_делить_Click(object sender, EventArgs e)
        {
            label3.Text = "Результат: " + Convert.ToString(Delenie(Convert.ToDouble(textBox_т_число1.Text), Convert.ToDouble(textBox_т_число2.Text)));
        }

        private void button_т_плюс_Click(object sender, EventArgs e)
        {
            label3.Text = "Результат: " + Convert.ToString(Summa(Convert.ToDouble(textBox_т_число1.Text), Convert.ToDouble(textBox_т_число2.Text)));
        }

        private void button_т_отнять_Click(object sender, EventArgs e)
        {
            label3.Text = "Результат: " + Convert.ToString(Minus(Convert.ToDouble(textBox_т_число1.Text), Convert.ToDouble(textBox_т_число2.Text)));
        }

        private void button_т_очистить_Click(object sender, EventArgs e)
        {
            textBox_т_число1.Clear();
            textBox_т_число2.Clear();
            label3.Text = "Результат:";
        }

        private void button_т_процент_Click(object sender, EventArgs e)
        {
            label3.Text = "Результат: " + Convert.ToString(Persent(Convert.ToDouble(textBox_т_число1.Text), Convert.ToDouble(textBox_т_число2.Text)));
        }

        private void button_т_встепень_Click(object sender, EventArgs e)
        {
            label3.Text = "Результат: " + Convert.ToString(Stepen(Convert.ToDouble(textBox_т_число1.Text), Convert.ToDouble(textBox_т_число2.Text)));
        }

        private void button_чистка_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }
        
        //******************************************************
        private void плюс_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox3.Text);
            textBox3.Clear();
            count = 1;
            label4.Text = a.ToString() + "+";
            znak = true;
        }

        private void минус_Click(object sender, EventArgs e)
        {
            a =double.Parse(textBox3.Text);
            textBox3.Clear();
            count = 2;
            label4.Text = a.ToString() + "-";
            znak = true;
        }

        private void умножить_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox3.Text);
            textBox3.Clear();
            count = 3;
            label4.Text = a.ToString() + "*";
            znak = true;
        }

        private void делить_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox3.Text);
            textBox3.Clear();
            count = 4;
            label4.Text = a.ToString() + "/";
            znak = true;
        }

        private void степень_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox3.Text);
            textBox3.Clear();
            count = 5;
            label4.Text = a.ToString() + " B ";
            znak = true;
        }

        private void процент_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox3.Text);
            textBox3.Clear();
            count = 6;
            label4.Text = a.ToString() + "%";
            znak = true;
        }

        private void корень_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox3.Text);
            textBox3.Clear();
            count = 7;
            label4.Text = a.ToString() + " ^ ";
            znak = true;
        }
        //******************************************************
        private void button_1_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + 1;
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + 2;
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + 3;
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + 4;
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + 5;
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + 6;
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + 7;
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + 8;
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + 9;
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + 0;
        }

        private void button_точка_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + ',';
        }

        //******************************************************

        private void button_равно_Click(object sender, EventArgs e)
        {
            
                calculate();
                label4.Text = "";
               
            
            
               
            } 
        //******************************************************
        private void calculate()
        {
            switch (count)
                {
                
                    case 1:
                        b = a + double.Parse(textBox3.Text);
                        textBox3.Text = b.ToString();
                        break;
                    case 2:
                        b = a - double.Parse(textBox3.Text);
                        textBox3.Text = b.ToString();
                        break;
                    case 3:
                        b = a * double.Parse(textBox3.Text);
                        textBox3.Text = b.ToString();
                        break;
                    case 4:
                        b = a / double.Parse(textBox3.Text);
                        textBox3.Text = b.ToString();
                        break;
                    case 5:                 //stepen 
                        b = Math.Pow(a, double.Parse(textBox3.Text));
                        textBox3.Text = b.ToString();
                        break;
                    case 6:                 //persent
                        b = (a * double.Parse(textBox3.Text)) / 100;
                        textBox3.Text = b.ToString();
                        break;

                    case 7:
                        b = a * Math.Sqrt(double.Parse(textBox3.Text));
                        textBox3.Text = b.ToString();
                        break;

                    default:
                        break;
                        
                
            }

        }
        //******************************************************
        public static double Summa(double one, double two)
        {
            return one + two;
        }
        public static double Minus(double one, double two)
        {
            return one - two;
        }
        public static double Delenie(double one, double two)
        {
            return one / two;
        }
        public static double Umnozhenie(double one, double two)
        {
            return one * two;
        }
        public static double Persent(double one, double two)
        {
            return (one * two) / 100;
        }
        public static double Stepen(double one, double two)
        {
            return Math.Pow(one, two);
        }
        //******************************************************


        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message =
                "\t Калькулятор ver 1.2 ."+"\n" + "Добавлены функции добавления и извлечения из автозагрузки." 
                + "\n"  + "\t Создатель: Iki. (^_^)";
            string caption = "Справка";
            var result = MessageBox.Show(message, caption);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void добавитьВАвтозагрузкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string name = "Calculator_IKI";


            string ExePath = System.Windows.Forms.Application.ExecutablePath;
            RegistryKey reg;
            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            
                    reg.SetValue(name, ExePath);
               
          
        }
        
        private void извлечьИзАвтозагрузкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string name = "Calculator_IKI";


            string ExePath = System.Windows.Forms.Application.ExecutablePath;
            RegistryKey reg;
            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
           
                    reg.DeleteValue(name);

                reg.Close();
          
        }

    }
    }

