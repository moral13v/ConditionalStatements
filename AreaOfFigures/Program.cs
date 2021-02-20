using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());

                double area = side * side;

                Console.WriteLine("{0:F3}", area);
            }

            else if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());

                double area = sideA * sideB;

                Console.WriteLine("{0:F3}", area);

            }

            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());

                double area = Math.PI * r * r;

                Console.WriteLine("{0:F3}", area);
            }

            else if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());

                double area = side * h / 2;

                Console.WriteLine("{0:F3}", area);
            }
        }
    }
}