using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(suma(3,4));
            System.Console.WriteLine(suma(1.71, 3));
            System.Console.WriteLine(suma(2,2,2,2));
            
        }

        static int suma(int operador1, int operador2)=> operador1+operador2;
        
        static double suma(double numero1, int numero2)=> numero1+numero2;

        static int suma(int numero1, int numero2, int numero3, int numero4)=> numero1+numero2+numero3+numero4;
       
       
    }
}
