using System;
// using MathOperations;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            int sum = MathOperations.Add(num1, num2);
            Console.WriteLine($"{num1} + {num2} = {sum}");
            Console.ReadLine();
        }
    }
}
