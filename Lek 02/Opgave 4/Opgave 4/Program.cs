using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_4
{
    class Program
    {
        static void Main(string[] args)
        {
            FindAge(1987);
        }

        static void FindAge(int birthYear)
        {

            int currentYear = Convert.ToInt32(DateTime.Now.Year);
            int age = currentYear - birthYear;

            Console.WriteLine($"Den fundne alder for årstallet {birthYear} er: {age}\nTryk ENTER for at lukke konsollen!");
            Console.ReadKey();

        }
    }
}
