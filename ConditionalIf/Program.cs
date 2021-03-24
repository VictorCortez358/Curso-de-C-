using System;

namespace ConditionalIf
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.Write("Ingrese su edad:");
            int edad= Int32.Parse(Console.ReadLine());

            if(edad < 18)System.Console.WriteLine("Eres un niño");

            else if(edad <30)System.Console.WriteLine("Eres joven");

            else if(edad <60)System.Console.WriteLine("Eres maduro");

            else System.Console.WriteLine("Eres mayor");
        
        
            
        

        


        }
    }
}
