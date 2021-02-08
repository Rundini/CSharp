using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            Console.WriteLine($"Her bruges 'IncrementValue()' med en int som parameter, værdien af 'a' er _{a}_ før metoden køres:");
            IncrementValue(a);
            Console.WriteLine($"Her er værdien af 'a', efter metoden er kørt:\t{a}\n");

            // ---------------------------------------------------------------------------------------

            Console.WriteLine($"Her bruges 'IncrementValue()' med en en ref til 'int a', værdien af 'a' er _{a}_ før metoden køres:");
            IncrementValue(ref a);
            Console.WriteLine($"Her er værdien af 'a', efter metoden er kørt:\t{a}\n");

            // ---------------------------------------------------------------------------------------

            Console.WriteLine($"Værdien af 'a' er nu {a}");
            IncrementValue(ref a);IncrementValue(ref a);IncrementValue(ref a);
            Console.WriteLine($"Efter metoden er kørt 3 gange mere er den:\t{a}\n");

            // ---------------------------------------------------------------------------------------

            IncrementValue(a);IncrementValue(a);IncrementValue(a);
            Console.WriteLine($"Efter metoden er kørt 3 gange mere med int som parameter, så er værdien af 'a' stadig:\t{a}\n");

            Console.ReadLine();
        }

        private static void IncrementValue(ref int a)
        {
            a++;
        }

        private static void IncrementValue(int a)
        {
            a = a + 1;
        }
    }
}
