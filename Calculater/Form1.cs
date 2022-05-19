namespace Calculater
{
    public partial class Calculator : Form
    {
        double value = 0;
        string operation = "";
        bool operationPressed = false;
        public Calculator()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void ButtonC()
        {
            result.Text = "0";
            value = 0;
            equation.Text = "";
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            ButtonC();
        }
        public bool Buttons(bool operationPressed)
        {
            if ((result.Text == "0") || (operationPressed))
            {
                result.Clear();
            }
            return operationPressed = false;
        }
        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operationPressed))
            {
                result.Clear();
            }
            operationPressed = false;
            Button btn = (Button)sender;
            if (btn.Text == ",")
            {
                if (!result.Text.Contains(","))
                {
                    result.Text = result.Text + btn.Text;
                }
            }
            else
            {
                result.Text = result.Text + btn.Text;
            }
        }
        public string ButtonCE(string y)
        {
            return result.Text = "0"; // H�r �ndrar jag vad jag vill ha ut av ButtonCE
        }
        private void buttonCE_Click(object sender, EventArgs e)
        {
            ButtonCE("");  // P�verkar inte i testet, kan �ven skriva result.Text f�r att testet ska bli godk�nt
        }
        private void operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (value != 0)
            {
                buttonSum.PerformClick();
                operationPressed = true;
                operation = btn.Text;
                equation.Text = value + " " + operation;
            }
            else
            {                
                operation = btn.Text;
                value = Convert.ToDouble(result.Text);
                operationPressed = true;
                equation.Text = value + " " + operation;
            }
        }
        private void ButtonSum()
        {
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    result.Text = (value + double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
            value = double.Parse(result.Text);
            operation = "";
        }
        private void buttonSum_Click(object sender, EventArgs e)
        {
            ButtonSum();
        }
    }
}