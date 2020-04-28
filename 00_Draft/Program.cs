using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            string lineOne = "trassa";
            string lineTwo = "trasaghyhtt";

            int resultForOneWord = 0;

            foreach (var letterOne in lineOne)
            {
                foreach (var letterTwo in lineTwo)
                {

                    if (letterOne == letterTwo)
                    {
                        int letOneComp = 0;
                        int letTwoComp = 0;

                        foreach (var letterOneComparison in lineOne)
                        {
                            if (letterOneComparison == letterOne)
                            {
                                letOneComp++;
                            }
                        }
                        //Console.WriteLine($"letterOne: {letterOne} letOneComp: {letOneComp}");

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
                                Console.WriteLine($"letterOne:{letterOne} resultForOneWord{resultForOneWord}");
                                break;
                            }
                        //Console.WriteLine($"letterOne: {letterOne} letOneComp: {letTwoComp}");
                    }

                     
                }

                Console.WriteLine($"ResultForOneWord: {resultForOneWord}");
            }

            Console.WriteLine($"Write 'y' for exit from program");

            string answer = Console.ReadLine();

            if (answer == "y")
            {
                exit = true;
            }

        }
    }
}