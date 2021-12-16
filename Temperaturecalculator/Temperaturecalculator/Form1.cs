namespace Temperaturecalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // get input form textbox
            string input = textBoxC.Text;
            // f = c x 9/5 +32
            double c = Convert.ToDouble(input);
            double f =  c * 9 / 5 + 32;

            // show input to textbox
            textBoxF.Text = f.ToString() ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxF_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonconvert2_Click(object sender, EventArgs e)
        {
            // get input form textbox
            string input = textBoxF.Text;
            double f = Convert.ToDouble(input);
            double c = (f -32)/1.8 ;

            // show input to textbox
            textBoxC.Text = c.ToString();
        }
    }
}