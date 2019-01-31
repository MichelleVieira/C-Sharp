using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            // DECLARANDO VARIÁVEIS.

            double triangulo;
            double circulo;
            double trapezio;
            double quadrado;
            double retangulo;



            double a;
            double b;
            double c;

            string entrada = " ";

            // ENTRADA DE DADOS.

            Console.Write("CALCULADO ÁREA");

            Console.Write("Digite um número para A: ");
            entrada = Console.ReadLine();
            a = Convert.ToDouble(entrada);

            Console.Write("Digite um número para B: ");
            entrada = Console.ReadLine();
            b = Convert.ToDouble(entrada);

            Console.Write("Digite um número para C: ");
            entrada = Console.ReadLine();
            c = Convert.ToDouble(entrada);

            // CÁLCULO

            triangulo = ((a * c) / 2);

            circulo = (3.14159 * Math.Pow(c, 2));

            trapezio = (((a + b) * c) / 2);

            quadrado = (b * b);

            retangulo = (a * b);

            // SAIDA DE DADOS 

            Console.WriteLine(" TRIÂNGULO: " + triangulo);
            Console.WriteLine(" CÍRCULO: " + circulo);
            Console.WriteLine(" TRAPÉZIO: " + trapezio);
            Console.WriteLine(" QUADRADO: " + quadrado);
            Console.WriteLine(" RETÂNGULO: " + retangulo);

        }
    }
}
