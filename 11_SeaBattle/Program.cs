using System;

namespace _11_SeaBattle
{
    class SeaBattle
    {
        static void Main(string[] args)
        {
            int[,] massiv = new int[10, 10];

            int[,] result = matrixWithSheeps(massiv);

            matrixInConsole(result);
        }
        static int[,] matrixInConsole(int[,] matrix)
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
                Console.WriteLine();
            }
            return matrix;
        }

        static int[,] matrixWithSheeps(int[,] matrix)
        {
            Random rand = new Random();
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            int ship = 0;

            // enter 1x4
            int a = rand.Next(1, rows - 4);
            int b = rand.Next(1, rows - 4);
            int x = a;
            int y = b;
            for (int cell = 0; cell < 4; cell++)
            {
                if (matrix[a, b - 1] == 0 && matrix[a + 1, b - 1] == 0 && matrix[a + 1, b] == 0 &&
                    matrix[a + 1, b + 1] == 0 && matrix[a + 1, b + 2] == 0 && matrix[a + 1, b + 3] == 0 &&
                    matrix[a + 1, b + 4] == 0 && matrix[a, b + 4] == 0 && matrix[a - 1, b + 4] == 0 &&
                    matrix[a - 1, b + 3] == 0 && matrix[a - 1, b + 2] == 0 && matrix[a - 1, b + 1] == 0 &&
                    matrix[a - 1, b] == 0 && matrix[a - 1, b - 1] == 0)
                {
                    matrix[x, y] = 1;
                    y++;
                }
            }

            // enter 2x3
            ship = 0;
            while (ship < 2)
            {
                a = rand.Next(1, rows - 3);
                b = rand.Next(1, rows - 3);
                x = a;
                y = b;
                bool isShip = false;
                if (matrix[a, b] == 0)
                {
                    for (int cell = 0; cell < 3; cell++)
                    {
                        if (matrix[a, b - 1] == 0 && matrix[a + 1, b - 1] == 0 && matrix[a + 1, b] == 0 &&
                            matrix[a + 1, b + 1] == 0 && matrix[a + 1, b + 2] == 0 && matrix[a + 1, b + 3] == 0 &&
                            matrix[a, b + 3] == 0 && matrix[a - 1, b + 3] == 0 && matrix[a - 1, b + 2] == 0 &&
                            matrix[a - 1, b + 1] == 0 && matrix[a - 1, b] == 0 && matrix[a - 1, b - 1] == 0)
                        {
                            matrix[x, y] = 1;
                            y++;
                            isShip = true;
                        }
                        else
                        {
                            if (matrix[a, b - 1] == 0 && matrix[a + 1, b - 1] == 0 && matrix[a + 2, b - 1] == 0 &&
                                matrix[a + 3, b - 1] == 0 && matrix[a + 3, b] == 0 && matrix[a + 3, b + 1] == 0 &&
                                matrix[a + 2, b + 1] == 0 && matrix[a + 1, b + 1] == 0 && matrix[a, b + 1] == 0 &&
                                matrix[a - 1, b + 1] == 0 && matrix[a - 1, b] == 0 && matrix[a - 1, b - 1] == 0)
                            {
                                matrix[x, y] = 1;
                                x++;
                                isShip = true;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
                if (isShip == true)
                {
                    ship++;
                }
            }
            // enter 3x2

            ship = 0;
            while (ship < 3)
            {
                a = rand.Next(1, rows - 2);
                b = rand.Next(1, rows - 2);
                x = a;
                y = b;
                bool isShip = false;

                if (matrix[a, b] == 0)
                {
                    for (int cell = 0; cell < 2; cell++)
                    {
                        if (matrix[a, b - 1] == 0 && matrix[a + 1, b - 1] == 0 && matrix[a + 1, b] == 0 &&
                            matrix[a + 1, b + 1] == 0 && matrix[a + 1, b + 2] == 0 && matrix[a, b + 2] == 0 &&
                            matrix[a - 1, b + 2] == 0 && matrix[a - 1, b + 1] == 0 && matrix[a - 1, b] == 0 && matrix[a - 1, b - 1] == 0)
                        {
                            matrix[x, y] = 1;
                            y++;
                            isShip = true;
                        }
                        else
                        {
                            if (matrix[a, b - 1] == 0 && matrix[a + 1, b - 1] == 0 && matrix[a + 2, b - 1] == 0 &&
                               matrix[a + 2, b] == 0 && matrix[a + 2, b + 1] == 0 && matrix[a + 1, b + 1] == 0 && matrix[a, b + 1] == 0 &&
                                matrix[a - 1, b + 1] == 0 && matrix[a - 1, b] == 0 && matrix[a - 1, b - 1] == 0)
                            {
                                matrix[x, y] = 1;
                                x++;
                                isShip = true;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }

                if (isShip == true)
                {
                    ship++;
                }
            }

            // enter 4x1;
            ship = 0;
            while (ship < 4)
            {
                a = rand.Next(1, rows - 1);
                b = rand.Next(1, rows - 1);
                x = a;
                y = b;
                bool isShip = false;

                if (matrix[a, b] != 1)
                {
                    for (int cell = 0; cell < 1; cell++)
                    {
                        if (matrix[a, b - 1] == 0 && matrix[a + 1, b - 1] == 0 && matrix[a + 1, b] == 0 &&
                            matrix[a + 1, b + 1] == 0 && matrix[a, b + 1] == 0 &&
                            matrix[a - 1, b + 1] == 0 && matrix[a - 1, b] == 0 && matrix[a - 1, b - 1] == 0)
                        {
                            matrix[x, y] = 1;
                            isShip = true;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                if (isShip == true)
                {
                    ship++;
                }
            }

            return matrix;
        }
    }
}
