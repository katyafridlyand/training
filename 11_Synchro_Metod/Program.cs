using System;

namespace _11_Synchro_Metod
{
    class Metod_Learning
    {
        static void Main(string[] args)
        {
            string lineOne = "farankel";
            string lineTwo = "synchrofazatron";

            bool result = IsWordCreated(lineOne, lineTwo);
            string missingLettersLine = missingLetters(lineOne, lineTwo);

            Console.WriteLine($"We can create this word - {result}");
            Console.WriteLine($"Letters which are absent to create word '{lineOne}' by word '{lineTwo}': {missingLettersLine}");
            Console.ReadKey();
        }

        static bool IsWordCreated (string firstWord, string basicWord)
        {
                bool[] used = new bool[basicWord.Length];
                int resultForOneWord = 0;
                bool resultFinal = false;

                foreach (var letterOne in firstWord)
                {
                    for (int i = 0; i < basicWord.Length; i++)
                    {
                        if (letterOne == basicWord[i] && used[i] != true)
                        {
                            used[i] = true;
                            resultForOneWord++;
                            break;
                        }
                    }
                    if (resultForOneWord == firstWord.Length)
                    {
                        resultFinal= true;
                    }
                }
            return resultFinal;
        }

        static string missingLetters(string firstWord, string basicWord)
        {
            bool[] used = new bool[basicWord.Length];
            string resultLine = "";

            foreach (var letterOne in firstWord)
            {
                bool letter = false;
                for (int i = 0; i < basicWord.Length; i++)
                {
                    if (letterOne == basicWord[i] && used[i] != true)
                    {
                        used[i] = true;
                        letter = true;
                        break;
                    }
                }
                    if (letter == false)
                    {
                        resultLine += letterOne;
                    }
            }
            return resultLine;
        }
    }
}
