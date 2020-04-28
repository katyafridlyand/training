using System;

namespace _10_Matrix
{
    class Matrix
    {
        static void Main(string[] args)
        {
            int[,] matrixOne = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] matrixTwo = { { 1, 2, 3}, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] matrixResult = new int[3, 3];

            int rowsOne = matrixOne.GetUpperBound(0) + 1;
            int columnsOne = matrixOne.Length / rowsOne;

            int rowsTwo = matrixTwo.GetUpperBound(0) + 1;
            int columnsTwo = matrixTwo.Length / rowsTwo;

            int rowResult = matrixResult.GetUpperBound(0) + 1;
            int columnsResult = matrixResult.Length / rowResult;

            // Console.WriteLine("${rowResult},{columnsResult}");

             if (rowsOne==columnsTwo)

             {  
                  for (int i = 0; i < rowsOne; i++)
                  {
                    for (int j = 0; j < columnsOne; j++)
                    {
                        Console.Write($"{matrixOne[i, j]} \t");
                    }
                    Console.WriteLine();
 
                  }
                  Console.WriteLine($"*");

                  for (int i = 0; i < rowsTwo; i++)
                  {
                     for (int j = 0; j < columnsTwo; j++)
                     {
                    Console.Write($"{matrixTwo[i, j]} \t");
                     }
                   Console.WriteLine();

                  }
                   Console.WriteLine($"=");

                for (int indexColumn = 0; indexColumn < columnsResult; indexColumn++)
                {
                    for (int indexRow = 0; indexRow < rowResult; indexRow++)
                    {
                        for (int indR = 0; indR < rowsOne; indR++)
                        {
                            int indC = indR;

                            matrixResult[indexRow, indexColumn] += (matrixOne[indexRow, indC] * matrixTwo[indR, indexColumn]);
                        }                                         
                    }
                }

                for (int i = 0; i < rowResult; i++)
                {
                for (int j = 0; j < columnsResult; j++)
                {
                     Console.Write($"{matrixResult[i, j]} \t");
                }
                Console.WriteLine();

                 }
                Console.ReadKey();

             }
        }
    }
}
