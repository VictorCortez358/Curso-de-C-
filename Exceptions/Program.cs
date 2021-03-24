using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero= new Random();
            var aleatorio = numero.Next(0,100);

            var minumero=0;

            var intentos=0;

            Console.Write("Inserte un n entre 0 Y 100:");

            do
            {
              intentos++;
              try
              {
                 minumero= Int32.Parse(Console.ReadLine());
              }

              catch(Exception ex) when(ex.GetType()!=typeof(FormatException))
              {
                  Console.WriteLine("Has cometido un error, intentalo de nuevo");
                  //Console.WriteLine(ex.Message);
              }

              catch(FormatException e)
              {
                  Console.WriteLine("Has introducido texto");
              }
              
              if(minumero > aleatorio) Console.WriteLine("El numero es mayor");
              if(minumero < aleatorio) Console.WriteLine("El numero es menor");

            }while(aleatorio != minumero);

            Console.WriteLine($"Correcto has necesitado {intentos} intentos");
            Console.WriteLine("Apartir de esta linea de codigo el programa continuara"); 
        }
    }
}
