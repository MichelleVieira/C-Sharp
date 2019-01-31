using System;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal salario;
            string entrada = "";
            decimal porcentagem;


            Console.WriteLine(" IMPOSTO DE RENDA ");
            Console.Write(" Digite o valor do seu salário: ");
            entrada = Console.ReadLine();
            salario = Convert.ToDecimal(entrada);

            if (salario >= 0 && salario <= 2000)
            {
                Console.WriteLine("Isento");
            }

            else if (salario > 2000 && salario <= 3000)
            {

                porcentagem = ((salario * 8) / 100);

                Console.WriteLine(" R$ " + porcentagem);
            }

            else if (salario > 3000 && salario <= 4500)
            {
                porcentagem = ((salario * 18) / 100);

                Console.WriteLine(" R$ " + porcentagem);

            }
            else
            {
                porcentagem = ((salario * 28) / 100);

                Console.WriteLine(" R$ " + porcentagem);
            }

        }
    }
}