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
        public static float AddingFormula(float numberOne, float numberTwo)
        {
            return numberOne + numberTwo;
        }

        public static float SubstrationFormula(float numberOne, float numberTwo)
        {
            return numberOne - numberTwo;
        }

        public static float MultiplationFormula(float numberOne, float numberTwo)
        {
            return numberOne * numberTwo;
        }

        public static float DivisionFormula(float numberOne, float numberTwo)
        {
            return numberOne / numberTwo;
        }
    }
}
