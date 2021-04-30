using System;
using System.Globalization;

namespace coordenadasDeUmPonto
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split();
            double x = (double.Parse(valores[0], CultureInfo.InvariantCulture));
            double y = (double.Parse(valores[1], CultureInfo.InvariantCulture));

            if (x == 0 || y == 0)
            {
                if (x != 0 && y == 0)
                {
                    Console.WriteLine("Eixo X");
                }

                if (x == 0 && y != 0)
                {
                    Console.WriteLine("Eixo Y");
                }

                if (x == 0 && y == 0)
                {
                    Console.WriteLine("Origem");
                }
            }
            else
            {

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Q1");
                }

                if (x < 0 && y > 0)
                {
                    Console.WriteLine("Q2");
                }

                if (x < 0 && y < 0)
                {
                    Console.WriteLine("Q3");
                }

                if (x > 0 && y < 0)
                {
                    Console.WriteLine("Q4");
                }
            }

            Console.ReadLine();

        }
    }
}
