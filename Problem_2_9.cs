/*
Write a program that prints numbers from 1 to 10, and next to each number write whether it is even or odd.
*/

namespace Any_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine($"The Number {i} is EVEN");
                else
                    Console.WriteLine($"The NUmber {i} is ODD");
            }
        }
    }
}
