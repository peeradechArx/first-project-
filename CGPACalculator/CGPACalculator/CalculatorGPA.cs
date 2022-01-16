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

        GPACalculator1 GPACal = new GPACalculator1();
        public Form1()
        {
          InitializeComponent();
        }
         private void button1_Click(object sender, EventArgs e)
        {
            string strInput = textBox1GPA_input.Text;
            string name = textBoxGPAname_input.Text;

            double dInput = Convert.ToDouble(strInput);
            GPACal.addGPA (dInput, name);

            double gpax = GPACal.getGPAx();
            textBoxGPAX.Text = gpax.ToString();

            double max = GPACal.getMax();
            textBoxGPAMAX.Text = max.ToString();
            textBoxMaxName.Text = GPACal.getMaxName().ToString();

            double min = GPACal.getMin();
            textBoxGPAMIN.Text = min.ToString();
            textBoxminName.Text = GPACal.getMinName().ToString();

            textBox1GPA_input.Text = "";
            textBoxGPAname_input.Text = string.Empty;
            textBoxAllData.Text = GPACal.getAlldata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxGPAX.Text = " ";
            textBox1GPA_input.Text = " ";
            textBoxGPAMAX.Text = " ";
            textBoxGPAMIN.Text = " ";
            textBoxMaxName.Text = " ";
            textBoxminName.Text = " ";
            textBoxAllData.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
