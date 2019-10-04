using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormsPractice
{
    public class CalculatorService : ICalculatorService
    {
        public double add(double numberOne, double numberTwo)
        {
            double total = 0;
            total = numberOne + numberTwo;
            return total;
        }

        public double divide(double numberOne, double numberTwo)
        {
            double total = 0;
            total = numberOne / numberTwo;
            return total;
        }

        public double multiply(double numberOne, double numberTwo)
        {
            double total = 0;
            total = numberOne * numberTwo;
            return total;
        }

        public double subtract(double numberOne, double numberTwo)
        {
            double total = 0;
            total = numberOne - numberTwo;
            return total;
        }
    }
}
