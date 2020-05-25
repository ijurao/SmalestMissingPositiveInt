using System;

namespace SmallestPositiveMissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 1, 0, -1, -2 };
            int a = findSmallesElement(array);
            Console.WriteLine("Smalles missing int is {0}", a);
            Console.ReadLine();
        }

        static int findSmallesElement(int[] array)
        {
            Array.Sort(array);
            var min = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == min)
                {
                    min++;
                }

               
            }
            return min;
        }
    }
}
