using System;

namespace Week3_DIS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer value:");
            String userInput = Console.ReadLine();
            int x = Convert.ToInt32(userInput);
            int y= 2;
            int sum = 0;
            int calc;

            try
            {

                sum = x + y;
                Console.WriteLine("The Sum is:" + sum);

            }
            catch (Exception e)
            { Console.WriteLine(e.Message);
            }
           
        }
    }
}
