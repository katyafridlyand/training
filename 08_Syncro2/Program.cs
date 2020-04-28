using System;
using System.ComponentModel.DataAnnotations;

namespace _05_twoLines
{
    class Lines
    {
        static void Main(string[] args)
        {

            string[] lineOne = { "trol", "faran", "fazan", "narzan", "tron", "trassa", "tros" };
            string lineTwo = "synchrofazatron";
            int resultFinal = 0;

            foreach (string oneWord in lineOne)
            {
                bool[] used = new bool[lineTwo.Length];
                int resultForOneWord = 0;
                foreach (var letterOne in oneWord)
                {
                    for (int i = 0; i < lineTwo.Length; i++)
                    {
                        if (letterOne == lineTwo[i] && used[i] != true)
                        {
                            used[i] = true;
                            resultForOneWord++;
                            break;
                        }
                    }
                    if (resultForOneWord == oneWord.Length)
                    {
                        resultFinal++;
                    }
                }
            }
                Console.WriteLine($"Result is: {resultFinal}");
                Console.WriteLine($"Write 'y' for exit from program");
                string answer = Console.ReadLine();
        }
    }
}



