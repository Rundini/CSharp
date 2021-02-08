using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_1
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkingWithIntegers();
            OrderPrecedence();
            TestLimits();
            WorkWithDoubles();
            WorkWithDecimals();

            bool endApp = false;
            while (!endApp)
            {
                Console.WriteLine("Indtast en radius: ");
                double rad = Convert.ToDouble(Console.ReadLine());
                areaOfCircle(rad);

                Console.WriteLine();

                Console.WriteLine("Tryk 'x' og ENTER hvis du vil stoppe, ellers tryk blot ENTER! ");
                if (Console.ReadLine() == "x")
                {
                    endApp = true;
                }
            }
        }

        static void WorkingWithIntegers()
        {
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);

            c = a - b;
            Console.WriteLine(c);

            c = a * b;
            Console.WriteLine(c);

            c = a / b;
            Console.WriteLine(c);

            c = a + b - 12 * 17;
            Console.WriteLine(c);

            Console.WriteLine();
            Console.ReadKey();
        }
        static void OrderPrecedence()
        {
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d);

            d = (a + b) * c;
            Console.WriteLine(d);

            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);

            int e = 7;
            int f = 4;
            int g = 3;
            int h = (e + f) / g;
            Console.WriteLine(h);

            Console.WriteLine();
            Console.ReadKey();
        }

        static void TestLimits()
        {
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");

            Console.WriteLine();
            Console.ReadKey();
        }
        static void WorkWithDoubles()
        {
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine(d);

            double e = 19;
            double f = 23;
            double g = 8;
            double h = (e + f) / g;
            Console.WriteLine(h);

            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);

            Console.WriteLine();
            Console.ReadKey();
        }

        static void WorkWithDecimals()
        {
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");

            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);

            Console.WriteLine();
            Console.ReadKey();
        }

        static void areaOfCircle(double radius)
        {
            double result;

            result = (radius*radius)*Math.PI;

            Console.WriteLine($"Arealet for cirklen med radius {radius} er: " + result + "cm^2");

        }
    }
}
