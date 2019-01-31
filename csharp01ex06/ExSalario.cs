using System;

namespace Ex6Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal salario;
            string entrada = " ";
            decimal porcentagem;

            Console.WriteLine("Digite o valor do seu salário: ");
            entrada = Console.ReadLine();
            salario = Convert.ToDecimal(entrada);



            if ((salario >= 0) && (salario <= 400))
            {
                porcentagem = ((salario * 15) / 100);

                salario = salario + porcentagem;

                Console.WriteLine(" Novo salário:  " + salario);
                Console.WriteLine(" Reajuste ganho: " + porcentagem);
                Console.WriteLine(" Em percentual: 15 %");


            }
            else if ((salario > 400) && (salario <= 800))
            {
                porcentagem = ((salario * 12) / 100);

                salario = salario + porcentagem;

                Console.WriteLine(" Novo salário: " + salario);
                Console.WriteLine(" Reajuste ganho: " + porcentagem);
                Console.WriteLine(" Em percentual: 12 %");

            }
            else if ((salario > 800) && (salario <= 1200))
            {
                porcentagem = ((salario * 10) / 100);

                salario = salario + porcentagem;

                Console.WriteLine(" Novo salário: " + salario);
                Console.WriteLine(" Reajuste ganho: " + porcentagem);
                Console.WriteLine(" Em percentual: 10 %");

            }
            else if ((salario > 1200) && (salario <= 2000))
            {
                porcentagem = ((salario * 7) / 100);

                salario = salario + porcentagem;

                Console.WriteLine(" Novo salário: " + salario);
                Console.WriteLine(" Reajuste ganho: " + porcentagem);
                Console.WriteLine(" Em percentual: 7 %");
            }
            else
            {

                porcentagem = ((salario * 4) / 100);

                salario = salario + porcentagem;

                Console.WriteLine(" Novo salário: " + salario);
                Console.WriteLine(" Reajuste ganho: " + porcentagem);
                Console.WriteLine(" Em percentual: 4%");
            }

            Console.ReadKey();
        }
    }
}
