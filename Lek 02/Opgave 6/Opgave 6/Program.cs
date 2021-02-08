using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.MyNormalMethod();

        }

        public void MyNormalMethod(int num = 0)
        {
            Console.WriteLine("\tKør fejl medtoden!\t\t\t\t\t\t\t--- TRYK ENTER! ---");
            Console.ReadKey();
            try
            {
                MyMethodWithError();
            }
            catch (Exception e)
            {
                Console.WriteLine("\tFEJL: " + e.Message + "\t--- TRYK ENTER! ---");
            }
            finally
            {
                Console.ReadKey();
                Console.WriteLine("\n\tFejlen blev fanget! Tillykke, opgaven er løst, denne besked er skrevet i 'finally'-delen!\n\n\t\t\t\t ----- TRYK ENTER FOR AT AFSLUTTE! -----");
                Console.ReadKey();
            }
        }

        private void MyMethodWithError(int num = 0)
        {
            Console.WriteLine("\tFejlmetoden kører i 'try'-delen!");
            throw new Exception("Metoden skal gerne kunne fange denne fejl i 'catch'-delen!");
        }
    }
}
