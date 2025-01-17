using System.Data;
using System.Text.RegularExpressions;

namespace calculatorrr
{
    public partial class Calculator : Form
    {
        private string input = "";
        private bool isDotUsed = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }
        private void UpdateDisplay()
        {
            txtDisplay.Text = string.IsNullOrEmpty(input) ? "0" : input.Replace('*', 'x').Replace('/', '÷');
        }


        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(input) || input == "0")
                return;

            if ("+-*/".Contains(input[^1]))
                return;

            string currentText = input;

            // Spliter
            string[] parts = currentText.Split(new char[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length > 0)
            {
                if (parts.Length == 1)
                {
                    // Toggle the sign of the entire number
                    if (currentText.StartsWith("-"))
                    {
                        currentText = currentText.Substring(1);
                    }
                    else
                    {
                        currentText = "-" + currentText;
                    }
                }
                else
                {
                    // toggle the last part
                    string lastPart = parts.Last();
                    int lastIndex = currentText.LastIndexOf(lastPart);

                    if (!string.IsNullOrEmpty(lastPart))
                    {
                        if (lastPart.StartsWith("-"))
                        {
                            // remove negative
                            currentText = currentText.Substring(0, lastIndex) + lastPart.Substring(1);
                        }
                        else
                        {
                            // replacing redundant sign
                            currentText = currentText.Substring(0, lastIndex) + "-" + lastPart;
                            currentText = currentText.Replace("--", "+");
                            currentText = currentText.Replace("+-", "");
                        }
                    }
                }
            }
            input = currentText;

            UpdateDisplay();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(input))
                    return;

                if ("+-*/".Contains(input[^1]))
                {
                    input = input[..^1]; // remove last character in string
                }

                string expression = input.Replace('x', '*').Replace('÷', '/').Trim();

                if (expression.Contains("/0"))
                {
                    txtDisplay.Text = "Error";
                    input = "";
                    return;
                }

                DataTable table = new DataTable();
                object result = table.Compute(expression, "");

                txtDisplay.Text = Convert.ToDouble(result).ToString("G", System.Globalization.CultureInfo.InvariantCulture);
                input = txtDisplay.Text;

                isDotUsed = input.Contains(".");
            }
            catch (DivideByZeroException)
            {
                txtDisplay.Text = "Error";
                input = "";
            }
            catch
            {
                txtDisplay.Text = "Error";
                input = "";
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            input = "";
            isDotUsed = false;
            UpdateDisplay();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (input.Length > 0)
            {
                char removedChar = input[^1];
                input = input[..^1];

                if (removedChar == '.')
                {
                    isDotUsed = input.Contains(".");
                }

                UpdateDisplay();
            }
        }
        private void btnNum_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (txtDisplay.Text == "0" || txtDisplay.Text == "Error")
            {
                input = btn.Text;
            }
            else
            {
                if (input.Length > 0 && input[^1] == '0' &&
                    (input.Length == 1 || "+-*/".Contains(input[^2])))
                {
                    input = input[..^1] + btn.Text;
                }
                else
                {
                    input += btn.Text;
                }
            }

            UpdateDisplay();
        }
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!isDotUsed)
            {
                if (string.IsNullOrEmpty(input) || "+-*/".Contains(input[^1]))
                {
                    input += "0.";
                }
                else
                {
                    input += ".";
                }

                isDotUsed = true;
                UpdateDisplay();
            }
        }
        private void btnOperation_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            char newOperation = btn.Text switch
            {
                "×" => '*',
                "÷" => '/',
                _ => btn.Text[0]
            };

            if (!string.IsNullOrEmpty(input) && !"+-*/".Contains(input[^1]))
            {
                input += newOperation;
                isDotUsed = false;
            }
            else if (!string.IsNullOrEmpty(input) && "+-*/".Contains(input[^1]))
            {
                input = input[..^1] + newOperation; // Replace last operator
            }

            UpdateDisplay();
        }
    }
}
