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
            // Här vill vi nolla allt och tömma minnet i equation
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
                result.Clear(); // Om result är noll eller om man redan tryckt på en operation
            }
            return operationPressed = false; // Sätt då till false
        }
        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operationPressed))
            {
                result.Clear(); // Om där är en nolla ska rutan bli tom
            }
            operationPressed = false;
            Button btn = (Button)sender;
            if (btn.Text == ",")
            {
                if (!result.Text.Contains(","))
                {
                    result.Text = result.Text + btn.Text; // Kollar om result innhåller ett komma och skriver ut reault
                }
            }
            else
            {
                result.Text = result.Text + btn.Text; // annat skiver vi ut result här
            }
        }
        public string ButtonCE(string y)
        {
            return result.Text = "0"; // Här ändrar jag vad jag vill ha ut av ButtonCE
        }
        private void buttonCE_Click(object sender, EventArgs e)
        {
            ButtonCE("");  // Påverkar inte i testet, kan även skriva result.Text för att testet ska bli godkänt
        }
        private void operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (value != 0)
            {
                // Om där INTE är en nolla i result
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
            // Uträkningen
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