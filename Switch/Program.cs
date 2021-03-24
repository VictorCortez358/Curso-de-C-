using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Introduce n de mes para calculo de la comisión: ");
            int mes= Int32.Parse(Console.ReadLine());

            switch(mes)
            {
                case 1:
                System.Console.WriteLine("Mes escogido: Enero");
                break;
                case 2:
                System.Console.WriteLine("Mes escogido: Febrero");
                break;
                case 3:
                System.Console.WriteLine("Mes escogido: Marzo");
                break;
                case 4:
                System.Console.WriteLine("Mes escogido: Abril");
                break;
                case 5:
                System.Console.WriteLine("Mes escogido: Mayo");
                break;
                case 6:
                System.Console.WriteLine("Mes escogido: Junio");
                break;
                case 7:
                System.Console.WriteLine("Mes escogido: Julio");
                break;
                case 8:
                System.Console.WriteLine("Mes escogido: Agosto");
                break;
                case 9:
                System.Console.WriteLine("Mes escogido: Septiembre");
                break;
                case 10:
                System.Console.WriteLine("Mes escogido: Octubre");
                break;
                case 11:
                System.Console.WriteLine("Mes escogido: Noviembre");
                break;
                case 12:
                System.Console.WriteLine("Mes escogido: Diciembre");
                break;
                
            }


            
            System.Console.WriteLine("Ha terminado el programa");

        }
    }
}
