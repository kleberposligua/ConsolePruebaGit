using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePruebaGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo C#");
            Console.WriteLine("Integración de VS con Git");

            // Imprimir la suma de 2 números
            Console.WriteLine("La suma de 10 + 20: {0} ", (10 + 20));


            // Saludos desde la PUCESE
            Console.WriteLine("BIENVENIDOS A LA PUCESE");
            Console.WriteLine("SEGUNDO DE TIC");

            //Fin de clase
            Console.WriteLine("Time is over...");
            Console.WriteLine("la suma de 10 + 20 es {0}", funcionSuma(10, 20));
            Console.ReadKey();

            
        }

        public static int funcionSuma(int a, int b)
        {
            return (a + b);
        }
    }
}
