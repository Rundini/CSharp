using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_1
{
    class Mekaniker : Person
    {
        public Mekaniker(string navn, string adresse, int aarUdlaert, double timeloen) : base(navn, adresse)
        {
            AarUdlaert = aarUdlaert;
            Timeloen = timeloen;
        }

        public int AarUdlaert { get; }
        public double Timeloen { get; set; }

        public double UdregnUgeloen()
        {
            return (Timeloen * 37);
        }

        public new void PrintInfo()
        {
            Console.WriteLine($"[Mekaniker]" +
                $"\nNavn: {Navn}" +
                $"\nAdresse: {Adresse}" +
                $"\nUdlært år: {AarUdlaert}" +
                $"\nTimeløn: {Timeloen}kr");
        }

    }
}
