using System;

namespace MethodsParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Suma(7,8));
        }

        static double Suma(int n1, int n2)
        {
            return n1+n2;
        }
    }
} 
