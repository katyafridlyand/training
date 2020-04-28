using System;
using System.Security.Cryptography;

namespace _06_ChessBoard
{
    class Chess
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)

            {
                Console.Write("Enter central point's coordinates: (axis x) ");   // central point a;b
                string pointA = Console.ReadLine();
                Console.Write("Enter central point's coordinates: (axis y) ");
                string pointB = Console.ReadLine();

                int a = Int32.Parse(pointA);
                int b = Int32.Parse(pointB);

                Console.Write("Enter radius: ");
                string r = Console.ReadLine();

                int radius = Int32.Parse(r);                                     // radius

                Console.Write("Enter point's coordinates: (axis x) ");           // point a1;b1
                string pointA1 = Console.ReadLine();
                Console.Write("Enter point's coordinates: (axis y) ");
                string pointB1 = Console.ReadLine();

                int a1 = Int32.Parse(pointA1);
                int b1 = Int32.Parse(pointB1);

                int a2 = Math.Abs(a - a1);
                int b2 = Math.Abs(b - b1);

                double rad = Math.Sqrt(a2 * a2 + b2 * b2);

                string result;

                if (rad < radius)
                {
                    result = "point is in the circle";
                }
                else
                {
                    result = "point is out of circle";
                }

              //  Console.WriteLine($"a: {a} b: {b} radius: {radius} a1: {a1} b1 {b1} rad: {rad}");

                Console.WriteLine($"Result: {result}");

                Console.WriteLine($"Write 'y' for exit from program");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    exit = true;
                }

            }

        }
    }

}