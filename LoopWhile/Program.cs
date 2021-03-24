using System;

namespace LoopWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Deseas entrar en el bucle While: ");
            string respuesta= Console.ReadLine();

            while (respuesta != "no")
            {

                System.Console.WriteLine("estas ejecutando el interior del ciclo while");
                System.Console.WriteLine();
                System.Console.Write("Introduce tu nombre porfavor:");
                string nombre= Console.ReadLine();
                System.Console.WriteLine();

                System.Console.WriteLine($"Saldras del bucle {nombre} cuando respondas no a la pregunta");
                System.Console.WriteLine();
                System.Console.Write("Deseas repetir otra vez?:");
                respuesta= Console.ReadLine();

                
            }
            System.Console.WriteLine("Has salido del bucle");
            
        }
    }
}
