using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_5
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomGenerator();
        }

        static void RandomGenerator()
        {
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Med .Next(Int32, Int32) metoden:\t" + random.Next(1, 100) + ",\tmed .NextDouble() metoden:\t" + random.NextDouble());
            }
            Console.WriteLine(  "\nForskellen på de to metoder er tydelig, da .Next(Int32, Int32) giver et helt tal inden for den givne ramme.\n" +
                                "Samtidig giver .NextDouble() giver et tal mellem 0,0 og 1,0");
            Console.ReadKey();
        }
    }
}
