using System;

namespace Ex1
{
    internal class Fibonacci
    {
        static bool EhFibonacci(int numero)
        {
            if (numero < 0)
                return false;

            int a = 0, b = 1;
            if (numero == a || numero == b)
                return true;

            while (b < numero)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            return b == numero;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Verificação de Fibonacci\n----------------------------------");


            int numero = 21;

            if (EhFibonacci(numero))
            {
                Console.WriteLine($"{numero} esta na sequencia de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"{numero} n�o esta na sequencia de Fibonacci.");
            }
        }
    }
}
