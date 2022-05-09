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
        public void buttonC_Click(object sender, EventArgs e)
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
        public void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operationPressed)) // Kunde inte plocka ut if-stasen till en egen metod
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
            return result.Text = "0"; // Här ändrar jag vad jag vill ha ut av ButtonCE
        }
        public void buttonCE_Click(object sender, EventArgs e)
        {
            ButtonCE("");  // Påverkar inte i testet, kan även skriva result.Text för att testet ska bli godkänt
        }
        public void operator_Click(object sender, EventArgs e)
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
        public void ButtonSum()
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
        public void buttonSum_Click(object sender, EventArgs e)
        {
            ButtonSum();
        }
    }
}