using System;
using System.Collections.Generic;
using System.Text;

namespace TestingMathLibrary
{
    interface IMathLibrary
    {
        int Addition(int i, int j);
        int Subtraction(int i, int j);
        int Multiply(int i, int j);
        int Divide(int i, int j);
        int Power(int i, int j);
        int Square(int i);
        int Factorial(int i);
        int Modulo(int i, int j);

    }
}
