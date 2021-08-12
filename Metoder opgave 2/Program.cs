using System;

namespace Metoder_opgave_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Side a");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Side b");
            double b = Convert.ToInt32(Console.ReadLine());
            double c = Pythagoras(a, b);
            double biggestNumber = BiggestNumber(a, b);
            if (biggestNumber == 0)
                Console.WriteLine("a is bigger than b");
            else if (biggestNumber == 1)
                Console.WriteLine("b is bigger than a");
            else
                Console.WriteLine("a and b are equal");
        }
        public static double Pythagoras (double a, double b)
        {
            return Math.Sqrt((Math.Pow(a,2) + Math.Pow(b,2)));
        }
        public static double BiggestNumber(double a, double b)
        {
            if (a < b)
                return 0;
            else if (b < a)
                return 1;
            else
                return 2;

        }
    }
}
