using System;

namespace TestingMathLibrary
{   
   public class MathLib : IMathLibrary    
    {
        public int Addition(int i, int j)
        {
            return i + j;
        }

        public int Subtraction(int i, int j)
        {
            return i - j;
        }
// casting means idc what type was, want it returned the type in ()s
        public ulong Multiply(int i, int j)
        {
            return (ulong)(i * j); // casting example
        }

        public int Divide(int i, int j)
        {
            return i / j;
        }

        public int Power(int i, int j)
        {
            return i ^ j;
        }

        public int Square(int i)
        {
            return i^2;
        }

        public int Factorial(int i)
        {
            return i!;
        }

        public int Modulo(int i, int j)
        {
            return i % j; 
        }
    }
}
