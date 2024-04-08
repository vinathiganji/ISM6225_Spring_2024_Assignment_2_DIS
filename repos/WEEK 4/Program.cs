﻿namespace WEEK_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] bubble_sort_numbers = { 3, 62, 5, 16, 4, 10 };
            Bubble_Sort(bubble_sort_numbers);
            for (int i = 0; i < bubble_sort_numbers.Length; i++)
            {
                Console.Write("  " + bubble_sort_numbers[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit the program ...");
            Console.ReadKey(true);

        }
        static void Bubble_Sort(int[] bs_arr)
        {

            for (int i = 0; i < bs_arr.Length - 1; i++)
            {
                for (int x = 0; x < bs_arr.Length - i - 1; x++)
                {
                    if (bs_arr[x] > bs_arr[x + 1])
                    {
                        int temp = bs_arr[x];
                        bs_arr[x] = bs_arr[x + 1];
                        bs_arr[x + 1] = temp;
                    }
                }
            }


        }
    }
}