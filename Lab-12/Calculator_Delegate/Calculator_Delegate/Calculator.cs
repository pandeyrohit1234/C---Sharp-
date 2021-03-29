using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_Delegate
{
    class Calculator
    {
        public int n1 { get; set; }
        public int n2 { get; set; }
    }
    public int sub(int n1, int n2)
    {
        int ans = n1 - n2;
        return ans;
    }
}
