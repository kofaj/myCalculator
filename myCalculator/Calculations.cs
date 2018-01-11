using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace myCalculator
{
    public static class Calculations
    {
        public static double AddingFormula(double numberOne, double numberTwo)
        {
            return numberOne + numberTwo;
        }

        public static double SubstrationFormula(double numberOne, double numberTwo)
        {
            return numberOne - numberTwo;
        }

        public static double MultiplationFormula(double numberOne, double numberTwo)
        {
            return numberOne * numberTwo;
        }

        public static double DivisionFormula(double numberOne, double numberTwo)
        {
            return numberOne / numberTwo;
        }
    }
}
