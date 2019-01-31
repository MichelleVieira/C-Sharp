using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARAÇÃO DE VARIÁVEIS
            int a;
            int b;
            int c;

            string entrada = " ";

            // ENTRADA DE DADOS

            Console.WriteLine(" ORDEM CRESCENTE ");

            Console.Write("Digite um número inteiro: ");
            entrada = Console.ReadLine();
            a = Convert.ToInt32(entrada);


            Console.Write("Digite um outro número inteiro: ");

            entrada = Console.ReadLine();
            b = Convert.ToInt32(entrada);

            Console.Write("Digite mais um número inteiro: ");
            entrada = Console.ReadLine();
            c = Convert.ToInt32(entrada);

            if ((a < b) && (b < c))
            {
                Console.WriteLine(" ORDEM: " + a + "," + b + "," + c);
            }

            if ((c < a) && (a < b))
            {
                Console.WriteLine(" ORDEM: " + c + "," + a + "," + b);
            }

            if ((b < c) && (c < a))
            {

                Console.WriteLine(" ORDEM: " + b + "," + c + "," + a);
            }
            
            Console.ReadKey();

        }
    }
}