using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_1
{
    class Synsmand : Mekaniker
    {
        public Synsmand(string navn, string adresse, int aarUdlaert, double timeloen) : base(navn, adresse, aarUdlaert, timeloen)
        {

        }

        public int AntalSynPrUge { get; set; }

        public new double UdregnUgeloen()
        {
            return (Timeloen * 37) + (AntalSynPrUge * 290);
        }

        public new void PrintInfo()
        {
            Console.WriteLine($"[Synsmand]" +
                $"\nNavn: {Navn}" +
                $"\nAdresse: {Adresse}" +
                $"\nUdlært år: {AarUdlaert}" +
                $"\nTimeløn: {Timeloen}kr" +
                $"\nAntal syn i løbet af ugen: {AntalSynPrUge}\t- dette bruges til at udregne ugelønnen for en synsmand." +
                $"\nUdregnet ugeløn (antal syn x 290kr): {UdregnUgeloen()}kr");
        }

    }
}
