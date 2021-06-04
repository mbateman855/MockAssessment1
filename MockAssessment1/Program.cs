using System;

namespace MockAssessment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers to see if they are equal.");
            int a1 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            Console.WriteLine(IsTheSame(a1, b1));

            Console.WriteLine("Please enter two numbers to find the difference of.");
            double a2 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            Console.WriteLine(Subtract(a2, b2));

            Console.WriteLine("Please enter a number of floors for a building.");
            int a3 = int.Parse(Console.ReadLine());
            Console.WriteLine(FindBuildingType(a3));
        }
        static bool IsTheSame(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        static double Subtract(double num1, double num2)
        {
            num1 -= num2;
            return num1;
        }
        static string FindBuildingType(int num)
        {
            if (num >= 4 && num <= 10)
            {
                return "This is an office building!";
            }
            else if (num >= 50)
            {
                return "This is a SUPER skyscraper!";
            }
            else if (num >= 11 && num <= 49)
            {
                return "This is a skyscraper!";
            }
            else if (num <= 3)
            {
                return "This is a house!";
            }
            else
            {
                return default;
            }
        }
    }
}
