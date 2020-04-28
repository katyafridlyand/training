using System;

namespace _06_ChessBoard
{
    class Chess
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)

            {
                Console.Write("Type cell: ");
                string cell = Console.ReadLine();

                string lineOne = "aceg";
                string lineTwo = "bdfh";
                string color = "black";
                int cellOstatok = 0;
                bool number = false;

                for (int index = 0; index < cell.Length; index++)
                {
                    

                    for (int indexOne = 0; indexOne < lineOne.Length; indexOne++)
                    {



                        if (cell[index] == lineOne[indexOne])
                        {
                            cellOstatok = cell[1] % 2;
                            if (cellOstatok == 0)
                            {
                                number = true;
                            }

                        }

                    }

                    for (int indexTwo = 0; indexTwo < lineTwo.Length; indexTwo++)
                    {

                        if (cell[index] == lineTwo[indexTwo])
                        {
                            cellOstatok = cell[1] % 2;
                            if (cellOstatok == 1)
                            {
                                number = true;
                            }

                        }

                    }

                    
                }

                   if (number)
                    color = "white";
                    Console.WriteLine($"Result line is: {color}");

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