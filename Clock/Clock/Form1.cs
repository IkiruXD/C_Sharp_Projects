using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadTime();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void LoadTime()
        {
            DateTime tim = new DateTime();
            tim = DateTime.UtcNow.AddHours(2);
            label1.Text=tim.ToLongTimeString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadTime();
        }
    }
}
