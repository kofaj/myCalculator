using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace myCalculator
{
    public partial class Calculator : Form
    {
        private string onScreenNumber;
        private float firstCalculatingNumber = 0;
        private float secondCalculatingNumber = 0;
        private string mathSign = null;

        public Calculator()
        {
            InitializeComponent();
            resultScreen.Text = "0";
        }

        private void CalculateIfPossible()
        {
            if (mathSign != null)
            {
                switch (mathSign)
                {
                    case "+":
                        resultScreen.Text = String.Format("{0}", Calculations.AddingFormula(firstCalculatingNumber, secondCalculatingNumber));
                        break;
                    case "-":
                        resultScreen.Text = String.Format("{0}", Calculations.SubstrationFormula(firstCalculatingNumber, secondCalculatingNumber)); secondCalculatingNumber = firstCalculatingNumber;
                        break;
                    case "x":
                        resultScreen.Text = String.Format("{0}", Calculations.MultiplationFormula(firstCalculatingNumber, secondCalculatingNumber)); ;
                        break;
                    case "/":
                        resultScreen.Text = String.Format("{0}", Calculations.DivisionFormula(firstCalculatingNumber, secondCalculatingNumber));
                        break;

                    default:
                        break;
                }
            }

            ClearAllVariables();
        }


        private void ShowNumbersOnScreen()
        {
            resultScreen.Text = onScreenNumber;
        }

        private void commaButton_Click(object sender, EventArgs e)
        {

        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            mathSign = button.Text;
            firstCalculatingNumber = float.Parse(onScreenNumber);

            if (onScreenNumber == null && secondCalculatingNumber == -1)
            {
                resultScreen.Text = "Please insert number first";
            }
            else
            {
                switch (mathSign)
                {
                    case "+":
                        secondCalculatingNumber = firstCalculatingNumber;
                        onScreenNumber = null;
                        break;
                    case "-":
                        secondCalculatingNumber = firstCalculatingNumber;
                        onScreenNumber = null;
                        break;
                    case "x":
                        secondCalculatingNumber = firstCalculatingNumber;
                        onScreenNumber = null;
                        break;
                    case "/":
                        secondCalculatingNumber = firstCalculatingNumber;
                        onScreenNumber = null;
                        break;

                    default:
                        break;
                }
            }
        }

        private void NumberButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            onScreenNumber = onScreenNumber + button.Text;
            ShowNumbersOnScreen();
        }

        private void ClearAllVariables()
        {
            firstCalculatingNumber = 0;
            secondCalculatingNumber = 0;
            mathSign = null;
            onScreenNumber = null;
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            if (firstCalculatingNumber != 0 && secondCalculatingNumber != 0)
            {
                CalculateIfPossible();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ClearAllVariables();
            resultScreen.Text = "0";
        }
    }
}
