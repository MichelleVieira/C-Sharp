using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            int meses;
            int dias;
            int semanas;
            string entrada = "";

            Console.Write("Digite a sua idade: ");
            entrada = Console.ReadLine();
            idade = Convert.ToInt32(entrada);

            dias = idade * 365;
            semanas = idade * 48;
            meses = idade * 12;


            Console.WriteLine(" Dias: " + dias);
            Console.WriteLine(" Semanas: " + semanas);
            Console.WriteLine(" Meses: " + meses);


            Console.ReadKey();
        }
    }
}
