using System;

namespace GitHub
{
    class Program
    {
        static void Main()
        {
            char [,] map = new char[5,5];
             
            int currentRow = 0;
            int currentCol = 0;
            FillMapDots(map);

            while (true)
            {
                PrintMap(map);

                var pressedKey = Console.ReadKey();
                try
                {
                    switch (pressedKey.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            MoveLeft(map, --currentCol, currentRow);
                            break;
                        case ConsoleKey.RightArrow:
                            MoveRight(map, ++currentCol, currentRow);
                            break;
                        case ConsoleKey.UpArrow:
                            MoveUp(map, currentCol, --currentRow);
                            break;
                        case ConsoleKey.DownArrow:
                            MoveDown(map, currentCol, ++currentRow);
                            break;
                        default:
                            Console.WriteLine("Invalid Command!");
                            break;
                    }

                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Invalid Command!");
                    currentRow = 0;
                    currentRow = 0;
                }
            }

        }

        private static void FillMapDots(char[,] map)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    map[i, j] = '.';
                }
            }
        }

        private static void PrintMap(char[,] map)
        {
            Console.Clear();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }

        }

        private static void MoveDown(char[,] map, int col, int row)
        {
            map[row, col] = '0';
            map[row - 1, col] = '.';
        }

        private static void MoveUp(char[,] map, int col, int row)
        {
            map[row, col] = '0';
            map[row + 1, col] = '.';
        }

        private static void MoveRight(char[,] map, int col, int row)
        {
            map[row, col] = '0';
            map[row, col - 1] = '.';
        }

        private static void MoveLeft(char[,] map, int col, int row)
        {
            map[row, col] = '0';
            map[row, col + 1] = '.';
        }


        
    }
}
