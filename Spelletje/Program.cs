using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spelletje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] array = CreateArray();
            PopulateArray(array);
            bool gameOver = false;

            Random random = new Random();
            int randomX, randomY;
            Randomize(random, out randomX, out randomY);

            ShowCoordinates(randomX, randomY);
            gameOver = GameLogic(array, gameOver, randomX, randomY);
        }

        private static string[,] CreateArray()
        {
            return new string[10, 10];
        }

        private static bool GameLogic(string[,] array, bool gameOver, int randomX, int randomY)
        {
            while (!gameOver)
            {
                ShowHeader(array);
                DrawArray(array);
                int userX, userY;
                UserInput(out userX, out userY);

                if (userX == randomX && userY == randomY)
                {
                    Console.WriteLine("Game over!");
                    gameOver = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    array[userX, userY] = "X";
                    Console.ResetColor();

                    if (userX < randomX)
                    {
                        Console.WriteLine("Hoger!");
                    }
                    else if (userX > randomX)
                    {
                        Console.WriteLine("Lager!");
                    }

                    if (userY < randomY)
                    {
                        Console.WriteLine("rechts!");
                    }
                    else if (userY > randomY)
                    {
                        Console.WriteLine("links!");
                    }

                    Console.ReadKey();
                    Console.Clear();
                    ShowCoordinates(randomX, randomY);
                }
            }

            return gameOver;
        }

        private static void UserInput(out int userX, out int userY)
        {
            Console.Write("X coordinaat :");
            userX = int.Parse(Console.ReadLine());
            Console.Write("Y coordinaat :");
            userY = int.Parse(Console.ReadLine());
        }

        private static void Randomize(Random random, out int randomX, out int randomY)
        {
            randomX = random.Next(0, 10);
            randomY = random.Next(0, 10);
        }

        private static void ShowCoordinates(int randomX, int randomY)
        {
            Console.WriteLine("X : " + randomX);
            Console.WriteLine("Y : " + randomY);
            Console.WriteLine();
        }

        private static void DrawArray(string[,] array)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                   if (array[i, j] == "X")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    Console.Write(array[i, j].PadLeft(4));
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        private static void PopulateArray(string[,] array)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    array[i, j] = "_";
                }
            }
            
        }

        private static void ShowHeader(string[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(i.ToString().PadLeft(4));
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}
