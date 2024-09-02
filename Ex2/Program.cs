using System;

namespace Ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string palavra = "plvr";
            int cont = 0;
            for (int i = 0; i < palavra.Length; i++) 
            {
                if(palavra[i] == 'A' || palavra[i] == 'a')
                {
                    cont++;
                }
            }
            Console.WriteLine(cont);
        }

    }
}


