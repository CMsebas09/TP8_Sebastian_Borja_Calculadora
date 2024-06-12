namespace GraficoC
{
    public partial class Form1 : Form
    {
        Double valorResultado = 0;
        String operador = "";
        bool isOperador = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            switch (operador)
            {
                case "+":
                    textBox1.Text = (valorResultado + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (valorResultado + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (valorResultado + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (valorResultado + Double.Parse(textBox1.Text)).ToString();
                    break;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1) textBox1.Text = "0";
            else textBox1.Text = textBox1.Text.Substring(0, textBox1.TextLength - 1);
        }
        private void operador_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (valorResultado != 0)
            {
                button11.PerformClick();
                operador = button.Text;
                label1.Text = valorResultado + " " + operador;
                isOperador = true;
            }
            else
            {
                operador = button.Text;
                valorResultado = Double.Parse(textBox1.Text);
                label1.Text = valorResultado + " " + operador;
                isOperador = true;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
