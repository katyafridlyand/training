using System;
using System.ComponentModel.DataAnnotations;

namespace _05_twoLines
{
    class Lines
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                string lineOne = "trol faza ron faran fazan narzan tron trassa tros";
                string[] words = lineOne.Split(new char[] { ' ' });
                string lineTwo = "synchrofazatron";
                int resultFinal = 0;

                foreach (string oneWord in words)
                {
                    int resultForOneWord = 0;
                    foreach (var letterOne in oneWord)
                    {
                        int lengthOneWord = oneWord.Length;
                        foreach (var letterTwo in lineTwo)
                        {
                            if (letterOne == letterTwo)
                            {
                                    int letOneComp = 0;
                                    int letTwoComp = 0;
                                foreach (var letterOneComparison in oneWord)
                                {
                                    if (letterOneComparison == letterOne )
                                    {
                                        letOneComp++; 
                                    }
                                }
                                 foreach (var letterTwoComparison in lineTwo)
                                 {
                                     if (letterTwoComparison == letterOne)
                                     {
                                            letTwoComp++;   
                                     }
                                 }
                                    if (letTwoComp >= letOneComp)
                                    {
                                        resultForOneWord++;
                                        break;
                                    }
                            }
                        }
                       // Console.WriteLine($"oneword: {oneWord} resfor1w: {resultForOneWord} and resfinal: {resultFinal}");

                        if (resultForOneWord == lengthOneWord)
                        {
                            resultFinal++;
                        }
                    }
                }
                Console.WriteLine($"Result is: {resultFinal}");
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



