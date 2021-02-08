using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN;

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                default:
                    break;
            }

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            Console.WriteLine("Konsol Lommeregner i C#\r");
            Console.WriteLine("-----------------------\n");

            while (!endApp)
            {
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                Console.Write("Indtast det først tal, og tryk ENTER: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Dette er ikke et gyldigt input! Indtast et tal! ");
                    numInput1 = Console.ReadLine();
                }

                Console.Write("Indtast det andet tal, og tryk ENTER: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("Dette er ikke et gyldigt input! Indtast et tal!");
                    numInput2 = Console.ReadLine();
                }

                Console.WriteLine("\nVælg en regnefunktion:");
                Console.WriteLine("\t+ - Læg sammen");
                Console.WriteLine("\t- - Træk fra");
                Console.WriteLine("\t* - Gange");
                Console.WriteLine("\t/ - Dividér");
                Console.Write("Dit valg: ");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("\nDenne operation vil give en fejl!\n");
                    }
                    else
                    {
                        Console.WriteLine($"\nDit resultat er: {result}\n");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Der opstod en fejl under udregningen: " + e.Message);
                }

                Console.WriteLine("-----------------------\n");

                Console.Write("Tast 'x' og ENTER for at afslutte, eller en vilkårlig tast og ENTER for at fortsætte!");
                if (Console.ReadLine() == "x")
                {
                    endApp = true;
                }

                Console.WriteLine("\n");

            }
            return;
        }
    }

}
