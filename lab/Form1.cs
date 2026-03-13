namespace lab
{
    public partial class Form1 : Form
    {
        private double prevValue = 0;
        private string currentOperator = "";
        private bool isNewInput = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            string label = ((Button)sender).Text;
            ProcessInput(label);
        }

        private void ProcessInput(string input)
        {
            if ("0123456789".Contains(input))
            {
                if (isNewInput)
                {
                    txtDisplay.Text = input;
                    isNewInput = false;
                }
                else
                {
                    txtDisplay.Text = txtDisplay.Text == "0" ? input : txtDisplay.Text + input;
                }
            }
            else if (input == ".")
            {
                if (isNewInput) { txtDisplay.Text = "0."; isNewInput = false; }
                else if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text += ".";
            }
            else if (input == "CE")
            {
                txtDisplay.Text = "0";
                isNewInput = true;
            }
            else if (input == "C")
            {
                txtDisplay.Text = "0";
                prevValue = 0;
                currentOperator = "";
                isNewInput = true;
            }
            else if (input == "+" || input == "-" || input == "*" || input == "/")
            {
                if (!isNewInput)
                {
                    if (currentOperator != "")
                        Calculate();
                    else
                        prevValue = double.Parse(txtDisplay.Text);
                }
                currentOperator = input;
                isNewInput = true;
            }
            else if (input == "=")
            {
                Calculate();
                currentOperator = "";
            }
        }

        private void Calculate()
        {
            double current = double.Parse(txtDisplay.Text);
            double result = 0;

            switch (currentOperator)
            {
                case "+": result = prevValue + current; break;
                case "-": result = prevValue - current; break;
                case "*": result = prevValue * current; break;
                case "/":
                    if (current == 0) { txtDisplay.Text = "Error"; isNewInput = true; return; }
                    result = prevValue / current;
                    break;
                default: return;
            }

            txtDisplay.Text = result % 1 == 0 ? ((long)result).ToString() : result.ToString();
            prevValue = result;
            isNewInput = true;
        }
    }
}