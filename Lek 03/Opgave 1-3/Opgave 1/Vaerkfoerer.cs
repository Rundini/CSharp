using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_1
{
    class Vaerkfoerer : Mekaniker
    {
        public Vaerkfoerer(string navn, string adresse, int aarUdlaert, double timeloen, int udnaevntAar, double tillaegUge) : base(navn, adresse, aarUdlaert, timeloen)
        {
            UdnaevntAar = udnaevntAar;
            TillaegUge = tillaegUge;
        }

        public int UdnaevntAar { get; }
        public double TillaegUge { get; set; }

        public new double UdregnUgeloen()
        {
            return (Timeloen * 37) + TillaegUge;
        }

        public new void PrintInfo()
        {
            Console.WriteLine($"[Værkfører]" +
                $"\nNavn: {Navn}" +
                $"\nAdresse: {Adresse}" +
                $"\nUdlært år: {AarUdlaert}" +
                $"\nUdnævnt til værksfører år: {UdnaevntAar}" +
                $"\nTimeløn: {Timeloen}kr, Ugentlig tillæg: {TillaegUge}kr");
        }
    }
}
