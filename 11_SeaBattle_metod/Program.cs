using System;

namespace _11_SeaBattleMetod
{
    class SeaBattle
    {
        static void Main(string[] args)
        {
            int[,] massive = new int[10, 10];
            int[,] result = MatrixWithAllShips(massive);

            Console.WriteLine(MatrixInString(result));
            Console.ReadKey();
        }
        static string MatrixInString(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            string matrixString = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {

                    matrixString += ($"{matrix[i, j]} \t");
                }
                matrixString += '\n';
                matrixString += '\n';
            }
            return matrixString;
        }

        static int[,] MatrixWithAllShips(int[,] matrix)
        {
            int fourShips = 4;
            int threeShips = 3;
            int twoShips = 2;
            int oneShip = 1;

            int fourCells = 4;
            int threeCells = 3;
            int twoCells = 2;
            int oneCell = 1;

            matrix = ShipOfCells(matrix, oneShip, fourCells);
            matrix = ShipOfCells(matrix, twoShips, threeCells);
            matrix = ShipOfCells(matrix, threeShips, twoCells);
            matrix = ShipOfCells(matrix, fourShips, oneCell);
            return matrix;
        }

        static int[,] ShipOfCells(int[,] matrix, int numberOfShips, int numberOfCells)
        {
            int ship = 0;
            bool isShip = false;
            while (ship < numberOfShips)
            {
                (int a, int b, int x, int y) = RandomNumbersForCell(matrix, numberOfCells);

                if (matrix[a, b] == 0)
                {
                    (int[,] matrixWithShip, bool isShipCells) = ConditionForShip(matrix, a, b, x, y, isShip, numberOfCells);

                    if (isShipCells == true)
                    {
                        ship++;
                    }
                    matrix = matrixWithShip;
                }
            }
            return matrix;
        }

        static (int[,], bool) ConditionForShip(int[,] matrix, int a, int b, int x, int y, bool isShip, int numberOfCells)
        {
            if (numberOfCells == 4)
            {
                if (ConditionForFourCells(matrix, a, b, x, y))
                {
                    for (int cell = 0; cell < numberOfCells; cell++)
                    {
                        matrix[x, y] = 1;
                        y++;
                        isShip = true;
                    }
                }
            }

            if (numberOfCells == 3)
            {
                if (ConditionForThreeCells(matrix, a, b, x, y))
                {
                    for (int cell = 0; cell < numberOfCells; cell++)
                    {
                        matrix[x, y] = 1;
                        y++;
                        isShip = true;
                    }
                }

            }


            if (numberOfCells == 2)
            {
                if (ConditionForTwoCells(matrix, a, b, x, y))
                {
                    for (int cell = 0; cell < numberOfCells; cell++)
                    {
                        matrix[x, y] = 1;
                        y++;
                        isShip = true;
                    }
                }

            }

            if (numberOfCells == 1)
            {
                if (ConditionForOneCell(matrix, a, b, x, y))
                {
                    for (int cell = 0; cell < numberOfCells; cell++)
                    {
                        matrix[x, y] = 1;
                        isShip = true;
                    }
                }
            }

            return (matrix, isShip);
        }

        static (int, int, int, int) RandomNumbersForCell(int[,] matrix, int numberOfCells)
        {
            Random rand = new Random();
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            int a = rand.Next(1, rows - numberOfCells);
            int b = rand.Next(1, rows - numberOfCells);
            int x = a;
            int y = b;

            return (a, b, x, y);
        }

        static bool ConditionForOneCell(int[,] matrix, int a, int b, int x, int y)
        {
            bool condition = false;
            if (matrix[a, b - 1] == 0 && matrix[a + 1, b - 1] == 0 && matrix[a + 1, b] == 0 &&
                                    matrix[a + 1, b + 1] == 0 && matrix[a, b + 1] == 0 &&
                                    matrix[a - 1, b + 1] == 0 && matrix[a - 1, b] == 0 && matrix[a - 1, b - 1] == 0)
            {
                condition = true;
            }

            return condition;
        }

        static bool ConditionForTwoCells(int[,] matrix, int a, int b, int x, int y)
        {
            bool condition = false;
            if (ConditionForOneCell(matrix, a, b, x, y) && (matrix[a + 1, b + 2] == 0
                                    && matrix[a, b + 2] == 0 && matrix[a - 1, b + 2] == 0))
            {
                condition = true;
            }
            else
            {
                if (ConditionForOneCell(matrix, a, b, x, y) && (matrix[a + 2, b - 1] == 0 &&
                               matrix[a + 2, b] == 0 && matrix[a + 2, b + 1] == 0))
                {
                    condition = true;
                }

            }

            return condition;
        }

        static bool ConditionForThreeCells(int[,] matrix, int a, int b, int x, int y)
        {
            bool condition = false;
            if (ConditionForTwoCells(matrix, a, b, x, y) && (matrix[a + 1, b + 3] == 0 &&
                                    matrix[a, b + 3] == 0 && matrix[a - 1, b + 3] == 0))
            {
                condition = true;
            }
            else
            {
                if (ConditionForTwoCells(matrix, a, b, x, y) && (matrix[a + 1, b + 3] == 0 &&
                                    matrix[a, b + 3] == 0 && matrix[a - 1, b + 3] == 0))
                {
                    condition = true;
                }
            }

            return condition;
        }

        static bool ConditionForFourCells(int[,] matrix, int a, int b, int x, int y)
        {
            bool condition = false;
            if (ConditionForThreeCells(matrix, a, b, x, y) && (matrix[a + 1, b + 4] == 0 &&
                                       matrix[a, b + 4] == 0 && matrix[a - 1, b + 4] == 0))
            {
                condition = true;
            }
            else
            {
                if (ConditionForThreeCells(matrix, a, b, x, y) && (matrix[a + 1, b + 4] == 0 &&
                                          matrix[a, b + 4] == 0 && matrix[a - 1, b + 4] == 0))
                {
                    condition = true;
                }
            }

            return condition;

        }

    }
}
