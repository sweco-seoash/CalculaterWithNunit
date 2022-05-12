using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithNunit
{
    public class TestClass
    {    
            public double Add(double x, double y)
            {
                return x + y;
            }
            public double Substract(double x, double y)
            {
                return 10 - 2;
            }
            public double divide(double num1, double num2)
            {
                return num1 / num2;
            }
            public double Multiply(double num1, double num2)
            {                
                return num1 + num2;
            }
    }
}
