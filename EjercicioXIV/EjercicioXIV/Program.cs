using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioXIV
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int multiplo;
            bool error = false;

            Console.WriteLine("Ingrese un numero y se mostrara su tabla de multiplicar");

            do
            {
                do
                {
                    error = false;
                    if (!int.TryParse(Console.ReadLine(), out numero))
                    {
                        Console.WriteLine("Debe ingresar un numero entero positivo");
                        error = true;
                    }
                } while (error);

                if (numero<0)
                {
                    Console.WriteLine("Ingrese un numero entero positivo");
                }
            } while (numero < 0);
            
            for (int i=1;i<=10;i++)
            {
                multiplo = numero * i;
                Console.WriteLine(numero + " * " + i + " = " + multiplo);
            }

            Console.ReadKey();
        }
    }
}
