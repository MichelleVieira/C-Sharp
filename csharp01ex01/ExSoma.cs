using System;


namespace somaEx01
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 0;
            int b = 0;

            Console.WriteLine("Digite um numero inteiro: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Digite mais um numero interio: ");

            b = Convert.ToInt32(Console.ReadLine());

            int soma = 0;

            soma = a + b;

            Console.WriteLine("SOMA = " + soma);

            Console.ReadKey();

        }
    }
}