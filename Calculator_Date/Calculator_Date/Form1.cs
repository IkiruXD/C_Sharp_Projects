using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Date
{
    public partial class Form1 : Form
    {

        int Bday;
        int Bmonth;
        int Byear;

        int Nday;
        int Nmonth;
        int Nyear;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Bday = int.Parse(textBox1.Text);
            Bmonth = int.Parse(textBox2.Text);
            Byear = int.Parse(textBox3.Text);

            Nday = int.Parse(textBox4.Text);
            Nmonth = int.Parse(textBox5.Text);
            Nyear = int.Parse(textBox6.Text);

            DateTime Resultdate = new DateTime(Nyear, Bmonth, Bday);
            DateTime Newdate = new DateTime(Byear, 12, 31);
            DateTime Bdate = new DateTime(Byear, Bmonth,Bday);
            DateTime Ndate = new DateTime(Nyear, Nmonth, Nday);
            
            label7.Text = ("Вы прожили: " + Ndate.Subtract(Bdate));
            label8.Text = ("До Нового года осталось:  " + Newdate.Subtract(Bdate));
            label9.Text = (" До дня рождения осталось: " +Resultdate.Subtract(Ndate));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            label7.Text = ("Вы прожили: ");
            label8.Text = ("До Нового года осталось:  ");
            label9.Text = (" До дня рождения осталось: ");
        }
    }
}
