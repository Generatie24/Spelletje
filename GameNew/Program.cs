using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userX, userY;
            Random random = new Random();
            int randomX, randomY;
           // Randomize(random, out randomX, out randomY);
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

        //private static void Randomize(Random random, out int randomX, out int randomY)
        //{
            
        //    int randomX = random.Next(0, 10);
        //    int randomY = random.Next(0, 10);
        //}
    }
}
