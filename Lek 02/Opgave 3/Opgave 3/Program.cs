using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast en grænseværdi: ");
            double borderValue = Convert.ToDouble(Console.ReadLine());
            Fib(borderValue);
        }

        static void Fib(double borderValue)
        {
            bool endApp = false;
            while (!endApp)
            {
                int temp1 = 0;
                int temp2 = 1;
                int temp3 = 0;

                Console.WriteLine(temp1);
                Console.WriteLine(temp2);

                for (int i = 2; temp3 <= borderValue; i++)
                {
                    temp3 = temp1 + temp2;
                    if (temp3 <= borderValue)
                    {
                        Console.WriteLine(temp3);
                        temp1 = temp2;
                        temp2 = temp3;
                    }
                    else
                    {
                        Console.WriteLine("Rækkefølgen er slut inden for den givne grænseværdi!\n");
                    }
                }
                Console.WriteLine("Indtast en ny grænseværdi: ");
                borderValue = Convert.ToInt32(Console.ReadLine());

                if (borderValue == 0)
                {
                    endApp = true;
                }
            }
        }
    }
}

