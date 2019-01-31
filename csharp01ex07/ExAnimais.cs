using System;

namespace Ex7
{
    class Program
    {
        private static string Vertebrado;

        static void Main(string[] args)
        {

            string entrada1;
            string entrada2;
            string entrada3;


            Console.Write("Informe se o animal é vertebrado ou invertebrado: ");
            entrada1 = Console.ReadLine();

            Console.Write(" Informe se o animal é ave, mamifero, inseto ou anelideo: ");
            entrada2 = Console.ReadLine();

            Console.Write(" Informe se o animal é carnivoro, onivoro, herbivoro ou hemafofago: ");
            entrada3 = Console.ReadLine();

            if (entrada1 == "vertebrado")
            {
                if (entrada2 == "ave")
                {
                    if (entrada3 == "carnivoro")
                    {
                        Console.WriteLine("AGUIA");
                    }
                    else if (entrada3 == " onivoro")
                    {
                        Console.WriteLine("POMBA");
                    }
                }
                else if (entrada2 == "mamifero")
                {
                    if (entrada3 == "onivoro")
                    {
                        Console.WriteLine("HOMEM");

                    }
                    else if (entrada3 == "herbivoro")
                    {
                        Console.WriteLine("VACA");

                    }
                }
            }
            else if (entrada1 == "invertebrado")
            {
                if (entrada2 == "inseto")
                {
                    if (entrada3 == "hematofago")
                    {
                        Console.WriteLine("PULGA");

                    }
                    else if (entrada3 == "herbivoro")
                    {
                        Console.WriteLine("LARGATA");
                    }
                }
                else if (entrada2 == "anelideo")
                {
                    if (entrada3 == "hematofago")
                    {
                        Console.WriteLine("SANGUESSUGA");
                    }
                    else if (entrada3 == "onivoro")
                    {
                        Console.WriteLine("MINHOCA");
                    }
                }
            }


            Console.ReadKey();
        }
    }
}
