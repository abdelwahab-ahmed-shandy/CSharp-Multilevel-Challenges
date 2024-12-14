/*
Problem_15 >>Rectangle Area 
Write a program to calculate rectangle area and print it on the screen 
// Area = a*b 

 */

using System.Numerics;

namespace PracticalExample
{
    internal class Program
    {
        public static void ReadNumbers(ref double Length, ref double Width)
        {
            Console.WriteLine("Rectangle Area Write a program to calculate rectangle area and print it on the screen  , Area = a*b\n");
            Console.Write("Enter Number One  : ");
            Length = double.Parse(Console.ReadLine());
            Console.Write("Enter Number Two  : ");
            Width = double.Parse(Console.ReadLine());   
        }
        public static double CalcRectangleArea(double Length, double Width)
        {
            return Length * Width;
        }

        public static void PrintResultArea(double RectangleArea)
        {
            Console.WriteLine($"\nThe Rectangle Area is : {RectangleArea}\n");
        }

        static void Main(string[] args)
        {
            double Length = 0 , Width = 0 ;
            ReadNumbers(ref Length, ref Width);
            PrintResultArea(CalcRectangleArea(Length, Width));
        }
    }
}
