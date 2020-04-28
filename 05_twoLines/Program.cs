using System;

namespace _05_twoLines
{
    class Lines
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)

            {
                Console.Write("Type the first line: ");
                string lineOne = Console.ReadLine();
                Console.Write("Type the second line: ");
                string lineTwo = Console.ReadLine();

                string lineResult = "";
                

                for (int indexOne = 0; indexOne < lineOne.Length; indexOne++)  //проверка первого слова
                {
                    for (int indexTwo = 0; indexTwo < lineTwo.Length; indexTwo++) //проверка второго слова
                    {
                        if (lineOne[indexOne] == lineTwo[indexTwo]) //если буквы равны, то проверка третьего слова
                        {
                            
                            bool res = true;
                            for (int indexThree = 0; indexThree < lineResult.Length; indexThree++)
                            {  
                                if (lineResult[indexThree] == lineOne[indexOne])
                                {
                                    res = false;
                                    break;
                                }

                            }
                                if (res)
                                {
                                lineResult = lineResult + lineOne[indexOne];
                                }

                        }
                        
                           // Console.WriteLine($"letter one: {lineOne[indexOne]} letter two {lineTwo[indexTwo]} and result line: {lineResult}");
                        
                    }
                    
                }


                Console.WriteLine($"Result line is: {lineResult}");
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



