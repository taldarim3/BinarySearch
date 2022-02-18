using System;

namespace BinarySearch
{
    internal class Program
    {
        public static int? BinarySearch(int[] array, int number)
        {
            int low = 0;
            int high = array.Length - 1;
            int steps = 0;
            while (low <= high)
            {
                steps++;
                int mid = (low + high) / 2;
                if (array[mid] == number)
                {
                    Console.WriteLine("Кол-во шагов " + steps);
                    return mid;
                }

                if (number < array[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return null;
        }

        public static void Main(string[] args)
        {
            int[] array = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            
            int? result = BinarySearch(array, 1);
            Console.WriteLine(result);
        }
    }
    
}