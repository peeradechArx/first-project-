using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV(*.csv) | *.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);
                string readallText = File.ReadAllText(openFileDialog.FileName);
                //this.textBox1.Text = readallText;

                for (int i = 0; i < readAllLine.Length; i++)
                {
                    string studentRAW = readAllLine[i];
                    string[] studentSplited = studentRAW.Split(',');
                    Student student = new Student(studentSplited[0], studentSplited[1], studentSplited[2]);
                }
                //addDatatoGridview("B1", "nlme", "cis");
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strdata = string.Empty;


            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV(*.csv) | *.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName != string.Empty)
                {
                    int column = this.dataGridView1.Rows.Count;
                    int Row = 0;
                    for (int i = 0; i < Row; i++)
                    {

                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            strdata = this.dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }

                File.WriteAllText(saveFileDialog.FileName, strdata, Encoding.UTF8);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[0].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[0].Cells[2].Value = comboBox1.Text;


            Calculator calculator = new Calculator();
            string input = textBoxGPA_input.Text;
          

            double dInput = Convert.ToDouble(input);
            calculator.addGPA(dInput, Name);

            double gpax = calculator.getGPAx();
            textBoxGPAx.Text = gpax.ToString();

            double max = calculator.getMax();
            textBoxMax.Text = max.ToString();

            double min = calculator.getMin();
            textBoxMin.Text = min.ToString();



        }
    }
}


