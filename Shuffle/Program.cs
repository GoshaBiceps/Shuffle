using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shuffle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            DrawArray(array);
            Shuffle(array);
            DrawArray(array);
        }

        static void DrawArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();
        }

        static void Shuffle(int[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                int number = array[i];
                int index = random.Next(0, array.Length);

                array[i] = array[index];
                array[index] = number;
            }
        }
    }
}
