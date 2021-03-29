using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator_Test
{
    [TestClass]
  
    public class CalculatorTest
    {
            public ICalculator C;
            private int num1;
            private int num2;
            private int addresult;

            [TestInitialize]
            public void TestSeup()
                {
                 C = new Calculator();
                 num1 = 9;
                 num2 = 2;
                 
            addresult = 11;
                }

        [TestMethod ]
        public void TestMethod()
        {
            C = new Calculator();
        }
        
    }
    
}
