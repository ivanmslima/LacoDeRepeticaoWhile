using System;
using System.Globalization;

namespace curso
{
    class Progam
    {
        static void Main(string[] args)
        {
            int numero;
            int cont = 1;

            Console.WriteLine("Digite um número maior que 0: ");
            numero = int.Parse(Console.ReadLine());

            if(numero > 0)
            {
                while(cont <= numero)
                {
                    Console.WriteLine(cont);
                    cont++;
                }
            }
            else
            {
                Console.WriteLine("Digite apenas números maiores que zero! ");
            }
            Console.WriteLine();

        }
    }
}