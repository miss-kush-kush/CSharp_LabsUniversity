namespace Calculator
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operation = string.Empty;
        string fstNum, secNum;
        bool enterValue = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumClick(object sender, EventArgs e)
        {
            if (tbDisplayResult.Text == "0" || enterValue || tbDisplayResult.Text == "division by 0")
            {
                tbDisplayResult.Text = string.Empty;
            }

            enterValue = false;
            Button button = (Button)sender;
            if (button.Text == ",")
            {
                if (!tbDisplayResult.Text.Contains(","))
                {
                    tbDisplayResult.Text = tbDisplayResult.Text + button.Text;
                }
            }
            else
                tbDisplayResult.Text = tbDisplayResult.Text + button.Text;
        }

        private void btnMathOperation_Click(object sender, EventArgs e)
        {
            if (result != 0)
            {
                btnEquals.PerformClick();
            }
            else result = double.Parse(tbDisplayResult.Text);

            Button button = (Button)sender;
            operation = button.Text;
            enterValue = true;

            if (tbDisplayResult.Text != "0" || tbDisplayResult.Text != "division by 0")
            {
                tbHistory.Text = fstNum = $"{result} {operation}";
                tbDisplayResult.Text = string.Empty;
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            secNum = tbDisplayResult.Text;
            tbHistory.Text = $"{tbHistory.Text} {tbDisplayResult.Text} = ";
            if (tbDisplayResult.Text != string.Empty)
            {
                if (tbDisplayResult.Text == "0" || tbDisplayResult.Text == "division by 0")
                {
                    tbHistory.Text = string.Empty;
                }

                switch (operation)
                {
                    case "+":
                        tbDisplayResult.Text = (result + Double.Parse(tbDisplayResult.Text)).ToString();
                        break;
                    case "-":
                        tbDisplayResult.Text = (result - Double.Parse(tbDisplayResult.Text)).ToString();
                        break;
                    case "×":
                        tbDisplayResult.Text = (result * Double.Parse(tbDisplayResult.Text)).ToString();
                        break;
                    case "÷":
                        double divisor = Double.Parse(tbDisplayResult.Text);

                        if (divisor != 0)
                        {
                            tbDisplayResult.Text = (result / divisor).ToString();
                        }
                        else
                        {
                            tbDisplayResult.Text = "division by 0";
                        }
                        break;
                    default:
                        tbHistory.Text = $"{tbDisplayResult.Text} = ";
                        break;
                }
            }

            if (tbDisplayResult.Text == "division by 0")
            {
                result = 0;
            }
            else result = Double.Parse(tbDisplayResult.Text);
            operation = string.Empty;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            tbDisplayResult.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            tbDisplayResult.Text = "0";
            tbHistory.Text = string.Empty;
            result = 0;
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (tbDisplayResult.Text.Length > 0)
            {
                tbDisplayResult.Text = tbDisplayResult.Text.Remove(tbDisplayResult.Text.Length - 1, 1);
            }
            if (tbDisplayResult.Text == string.Empty)
            {
                tbDisplayResult.Text = "0";
            }

        }

        private void btnOperations_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            switch (operation)
            {
                case "1/x":
                    tbHistory.Text = $"1/{tbDisplayResult.Text}";
                    tbDisplayResult.Text = Convert.ToString(1.0 / Double.Parse(tbDisplayResult.Text));
                    break;
                case "%":
                    tbHistory.Text = $"{tbDisplayResult.Text}%";
                    tbDisplayResult.Text = Convert.ToString(Double.Parse(tbDisplayResult.Text) / 100.0);
                    break;
                case "x^2":
                    tbHistory.Text = $"{tbDisplayResult.Text}^2";
                    tbDisplayResult.Text = Convert.ToString(Math.Pow(Double.Parse(tbDisplayResult.Text), 2));
                    break;
                case "√x":
                    tbHistory.Text = $"√({tbDisplayResult.Text})";
                    tbDisplayResult.Text = Convert.ToString(Math.Sqrt(Double.Parse(tbDisplayResult.Text)));
                    break;
                case "+/-":
                    tbHistory.Text = $"{tbDisplayResult.Text}";
                    tbDisplayResult.Text = Convert.ToString((-1.0) * Double.Parse(tbDisplayResult.Text));
                    break;
                default:
                    break;
            }
        }
    }
}