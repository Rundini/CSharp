using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ExploreIf();
            Loops();
            SumDivThree();
        }

        static void ExploreIf()
        {
            int a = 5;
            int b = 3;
            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10.");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }

            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }

            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            }

            Console.WriteLine();
            Console.ReadKey();
        }

        static void Loops()
        {
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }

            counter = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 10);

            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello World! The index is {index}");
            }

            for (int row = 1; row < 11; row++)
            {
                Console.WriteLine($"The row is {row}");
            }

            for (char column = 'a'; column < 'k'; column++)
            {
                Console.WriteLine($"The column is {column}");
            }

            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }

            Console.WriteLine();
            Console.ReadKey();
        }

        static void SumDivThree()
        {
            int temp = 0;
            for(int i = 1; i <= 20; i++)
            {
                if ((i % 3) == 0)
                {
                    temp += i;
                }
            }
            Console.WriteLine("Summen af tal fra 1-20 der kan gå op i 3 er: " + temp);
            Console.ReadKey();
        }
    }
}
