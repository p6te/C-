using System;

namespace Projekt1 // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj szerokość : ");
            string xs = Console.ReadLine();
            Console.Write("Podaj długość : ");
            string ys = Console.ReadLine();


            int x = int.Parse(xs);
            int y = int.Parse(ys);

            string gwiazdka = "*";

            for (int i = 0; i < x; i++)
            {
                Console.Write(gwiazdka);
            }

            Console.WriteLine();


            for (int i = 0; i < y; i++)
            {
                Console.Write(gwiazdka);

                for (int j = 0; j < x - 2; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine(gwiazdka);

            }

            for (int i = 0; i < x; i++)
            {

                Console.Write(gwiazdka);
            }
        }
    }
}