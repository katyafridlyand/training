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
                Console.Write("Type chessboard's cell: ");
                string cell = Console.ReadLine();
                cell = cell.ToLower();

                char a = cell[0]; 
                char b = cell[1];
                int result = 0;
                string color = "black";

                if ((a >= 'a' && a <= 'h') && (b >= '1' && b <= '8'))
                {
                    result = a + b;
                    result = result % 2;
                    
                   if (result==1)

                   {
                    color = "white";
                        
                   }
                    

                     Console.WriteLine($"Result line is: {color}");
                }

                else
                {
                    Console.WriteLine($"Type valid cell");
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

}