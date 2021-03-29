using CalculatorLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Calculator : ICalculator
    {
        public int Add(int num1, int num2)
        {
            var result = num1 + num2;
            return result;
        }

        public int Sub(int num1, int num2)
        {
            throw new NotImplementedException();
        }
    }
}
