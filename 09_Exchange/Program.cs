using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Schema;

namespace _09Excange
{
    class Lines
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                int[] massivOfNumbers = {5, 2, 3, 4, 1, 6, 7, 8, 9};

                int min = massivOfNumbers[0];
                int max = 0;
                int indexMin = 0;
                int indexMax = 0;

                for (int i=0; i<massivOfNumbers.Length; i++)
                {
                    if (massivOfNumbers[i]<min)
                    {
                        min = massivOfNumbers[i];
                        indexMin = i;
                    }
                    if (massivOfNumbers[i] > max)
                    {
                        max = massivOfNumbers[i];
                        indexMax = i;
                    }
                }
                massivOfNumbers[indexMax] = min;
                massivOfNumbers[indexMin] = max;

                string massivResult = String.Join(' ', massivOfNumbers);

                Console.WriteLine($"massiv:{massivResult}");
                Console.ReadKey();
            }
        }
    }
}



