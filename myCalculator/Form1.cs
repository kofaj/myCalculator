using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace myCalculator
{
    public partial class Calculator : Form
    {
        private double firstCalculatingNumber { get; set; }
        private double secondCalculatingNumber { get; set; }
        private double calculationResult { get; set; }

        private string temporaryNumber = null;
        private string onScreenNumber;
        private string mathSign = null;

        public Calculator()
        {
            InitializeComponent();
            resultScreen.Text = "0";
        }

        private void CalculateIfPossible()
        {
            switch (mathSign)
            {
                case "+":
                    calculationResult = Calculations.AddingFormula(firstCalculatingNumber, secondCalculatingNumber);
                    break;
                case "-":
                    calculationResult = Calculations.SubstrationFormula(firstCalculatingNumber, secondCalculatingNumber);
                    break;
                case "x":
                    calculationResult = Calculations.MultiplationFormula(firstCalculatingNumber, secondCalculatingNumber);
                    break;
                case "√":
                    calculationResult = Calculations.DivisionFormula(firstCalculatingNumber, secondCalculatingNumber);
                    break;
                case "/":
                    calculationResult = Calculations.DivisionFormula(firstCalculatingNumber, secondCalculatingNumber);
                    break;

                default:
                    break;
            }
        }

        private void ShowNumbersOnScreen([Optional] string lastSign)
        {
            if (lastSign == "=" || calculationResult > 0)
            {
                resultScreen.Text = String.Format("{0} = {1}", onScreenNumber, calculationResult);
                ClearAllVariables();
            }
            else if (lastSign == "+" || lastSign == "-" || lastSign == "x" || lastSign == "/" || lastSign == "√")
            {
                onScreenNumber = onScreenNumber + " " + mathSign + " ";
                resultScreen.Text = onScreenNumber;
            }
            else if (onScreenNumber != null)
            {
                onScreenNumber = onScreenNumber + Convert.ToString(lastSign);
                resultScreen.Text = onScreenNumber;
            }
            else
            {
                onScreenNumber = Convert.ToString(lastSign);
                resultScreen.Text = onScreenNumber;
            }
        }

        private void commaButton_Click(object sender, EventArgs e)
        {
            if (firstCalculatingNumber == 0)
            {
                onScreenNumber = "0,";
                firstCalculatingNumber = 0.1;
            }
            else if (onScreenNumber.Contains(",") == true)
            {
                onScreenNumber = onScreenNumber + ",";
            }
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            mathSign = button.Text;
            temporaryNumber = null;

            if (firstCalculatingNumber < 1)
            {
                resultScreen.Text = "Please insert number first";
                ClearAllVariables();
            }
            else if (firstCalculatingNumber > 0 && secondCalculatingNumber > 0)
            {
                CalculateIfPossible();
                firstCalculatingNumber = calculationResult;
                ShowNumbersOnScreen();
            }
            else ShowNumbersOnScreen(mathSign);
        }

        private void NumberButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            temporaryNumber = temporaryNumber + button.Text;
            ShowNumbersOnScreen(button.Text);
            GetAndAssaignNumbersForCalculating();
        }

        private void ClearAllVariables()
        {
            firstCalculatingNumber = 0;
            secondCalculatingNumber = 0;
            calculationResult = 0;
            temporaryNumber = null;
            mathSign = null;
            onScreenNumber = null;
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            string lastSign = "=";
            if (firstCalculatingNumber > -1 && secondCalculatingNumber > -1 && lastSign == "=")
            {
                CalculateIfPossible();
                ShowNumbersOnScreen(lastSign);
            }
            else
            {
                resultScreen.Text = "Error :(";
                ClearAllVariables();
            }
        }

        private void GetAndAssaignNumbersForCalculating()
        {
            if (mathSign == null)
            {
                firstCalculatingNumber = Convert.ToDouble(temporaryNumber);
            }
            else secondCalculatingNumber = Convert.ToDouble(temporaryNumber);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ClearAllVariables();
            resultScreen.Text = "0";
        }

        private void Shoortcut(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "1":
                    zeroButton.PerformClick();
                    break;
               /* case "-":
                    calculationResult = Calculations.SubstrationFormula(firstCalculatingNumber, secondCalculatingNumber);
                    break;
                case "x":
                    calculationResult = Calculations.MultiplationFormula(firstCalculatingNumber, secondCalculatingNumber);
                    break;
                case "√":
                    calculationResult = Calculations.DivisionFormula(firstCalculatingNumber, secondCalculatingNumber);
                    break;
                case "/":
                    calculationResult = Calculations.DivisionFormula(firstCalculatingNumber, secondCalculatingNumber);
                    break;*/

                default:
                    break;
            }
        }
    }
}
