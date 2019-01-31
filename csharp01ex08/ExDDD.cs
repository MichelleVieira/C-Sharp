using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada = "";
            int DDD = 0;

            Console.WriteLine("Digite um número inteiro que representa um código de DDD: ");
            entrada = Console.ReadLine();
            DDD = Convert.ToInt32(entrada);


            switch (DDD)
            {

                case 61:

                    Console.WriteLine("BRASILIA");

                    break;

                case 71:

                    Console.Write("SALVADOR");

                    break;

                case 11:

                    Console.WriteLine("SÃO PAULO");

                    break;

                case 21:

                    Console.WriteLine("RIO DE JANEIRO");

                    break;

                case 32:

                    Console.WriteLine("JUIZ DE FORA");

                    break;

                case 19:

                    Console.WriteLine("CAMPINAS");

                    break;

                case 27:

                    Console.WriteLine("VITORIA");

                    break;

                case 31:

                    Console.WriteLine("BELO HORIZONTE");

                    break;

                default:

                    Console.WriteLine(" DDD não cadastrado");

                    break;

            }

            Console.ReadKey();
        }
    }
}
