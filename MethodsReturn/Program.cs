using System;

namespace MethodsReturn
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(divideNumeros(18,7));
            
        }

        static double divideNumeros(double n1, double n2)
        {

            return n1 / n2;
        }

        // static void divideNumeros(double n1, double n2)=> n1/n2;


    }
}
