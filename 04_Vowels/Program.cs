using System;
using System.Runtime.CompilerServices;

namespace _04_Vowels
{
    class Vowels
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
           
            {
                Console.Write("Type something: ");
                string name = Console.ReadLine();
                string nameLower = name.ToLower();

                string vowels = "aoyuie";

                int numberOfVowels = 0;


                for (int index = 0; index < nameLower.Length; index++)

                {   for (int L = 0; L < vowels.Length; L++)
                   
                    {
                        if (nameLower[index] == vowels[L])

                        {
                            numberOfVowels++;
                         //   Console.WriteLine($"Vowel: {nameLower[index]} vowels {vowels[L]} and number: {numberOfVowels}");
                            break;
                        }
                        
                    }

                  //  Console.WriteLine($"Vowel: {nameLower[index]} vowels {vowels[indexL]} and number: {numberOfVowels}");
                }

                Console.WriteLine($"number of vowels: {numberOfVowels}");
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

       

     