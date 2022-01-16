using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGPACalculator
{
    public partial class Form1 : Form
    {
        double Sum = 0;
        int n = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string strInput = textBox1GPA_input.Text;
            //string name = GPA_input.Text;
            double dInput = Convert.ToDouble(strInput);

            Sum = Sum + dInput;
            n = n + 1;
            double result = Sum / n;
            textBoxGPAX.Text = result.ToString();
        }
    }
}
