using System;

namespace _10_MatrixMetod
{
    class MatrixMetod
    {
        static void Main(string[] args)
        {
            int[,] matrixOne = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] matrixTwo = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] matrixResultLength = new int[3, 3];

            int[,] matrixResult = matrixMultiply(matrixOne, matrixTwo, matrixResultLength);

            matrixInConsole(matrixOne);
             
            matrixInConsole(matrixTwo);

            matrixInConsole(matrixResult);

            Console.ReadKey();
        }

        static int[,] matrixInConsole (int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
            return matrix;
        }

        static int[,] matrixMultiply (int[,] matrixOne, int[,] matrixTwo, int[,] matrixResult)
        {
            int rowsOne = matrixOne.GetUpperBound(0) + 1;
            int columnsOne = matrixOne.Length / rowsOne;

            int rowsTwo = matrixTwo.GetUpperBound(0) + 1;
            int columnsTwo = matrixTwo.Length / rowsTwo;

            int rowResult = matrixResult.GetUpperBound(0) + 1;
            int columnsResult = matrixResult.Length / rowResult;

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

            return matrixResult;
        }

    }
}
