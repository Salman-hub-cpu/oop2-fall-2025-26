using System;

namespace DelegateExample
{
   
    delegate int Operation(int x, int y);

    class Program
    {
      
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Calculate(int a, int b, Operation op)
        {
            return op(a, b);
        }

        static void Main(string[] args)
        {
            int sum = Calculate(10, 5, Add);
            Console.WriteLine("Addition Result: " + sum);

            int difference = Calculate(10, 5, Subtract);
            Console.WriteLine("Subtraction Result: " + difference);

            Console.ReadLine();
        }
    }
}
