using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_1
{
    class VaerkstedMain
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n - -  - - - - - - - - - - - - - PERSON - - - - - - - - - - - - - - - \n");
            Person per = new Person("Rune", "Spørring");
            per.PrintInfo();

            //---------------------------------------------------------------------------------------------------------

            Console.WriteLine("\n\n - - - - - - - - - - - - - - - MEKANIKER - - - - - - - - - - - - - - - \n");
            Mekaniker mek = new Mekaniker("Klaus", "Solbjerg", 2008, 285);
            mek.PrintInfo();
            Console.WriteLine($"Her bruges opgave 3's metode til at udregen ugelønnen: {mek.UdregnUgeloen()}kr\n");

            mek.Navn = "Hans";
            mek.Adresse = "Hadsten";
            mek.Timeloen = 315;
            Console.WriteLine("Her er navn, adresse og løn ændret:");
            mek.PrintInfo();
            Console.WriteLine($"Opgave 3: {mek.UdregnUgeloen()}kr");

            //---------------------------------------------------------------------------------------------------------

            Console.WriteLine("\n\n - - - - - - - - - - - - - - - VÆRKFØRER - - - - - - - - - - - - - - - \n");
            Vaerkfoerer vaerk = new Vaerkfoerer("Albert", "Aarhus", 2005, 290, 2016, 2000);
            vaerk.PrintInfo();
            vaerk.Navn = "Niels";
            Console.WriteLine($"\nNavneskifte til {vaerk.Navn} og en udregning af ugelønnen: {vaerk.UdregnUgeloen()}kr\n");
            vaerk.TillaegUge = 3000;
            Console.WriteLine($"Det nye ugentlige tillæg er på {vaerk.TillaegUge}kr, derfor er den nye udregning: {vaerk.UdregnUgeloen()}kr");

            //---------------------------------------------------------------------------------------------------------

            Console.WriteLine("\n\n - - - - - - - - - - - - - - - SYNSMAND - - - - - - - - - - - - - - - \n");
            Synsmand syn = new Synsmand("Alfredo", "Herning", 2002, 200);
            Console.WriteLine("Her sættes antallet af syn til 0, 10 og 100\n");
            syn.AntalSynPrUge = 0;
            syn.PrintInfo();
            Console.WriteLine();

            syn.Navn = "John";
            syn.AntalSynPrUge = 10;
            syn.Timeloen = 240;
            syn.PrintInfo();
            Console.WriteLine();
            syn.Adresse = "Ikast";
            syn.AntalSynPrUge = 100;
            syn.PrintInfo();

            //---------------------------------------------------------------------------------------------------------

            Console.WriteLine("\n\n - - - - - - - - - - - - - - - ALLES LØN - - - - - - - - - - - - - - - \n");
            Console.WriteLine($"Mekanikeren {mek.Navn}' ugeløn er: {mek.UdregnUgeloen()}kr");
            Console.WriteLine($"Værkføren {vaerk.Navn}' ugeløn er: {vaerk.UdregnUgeloen()}kr");
            Console.WriteLine($"Synsmanden {syn.Navn}'s ugeløn er: {syn.UdregnUgeloen()}kr (med {syn.AntalSynPrUge} syn på en uge!)");

            //---------------------------------------------------------------------------------------------------------

            Console.WriteLine("\n\n - - - - - - - - - - - - - - - AFSLUT - - - - - - - - - - - - - - - \n"); ;
            Console.WriteLine("\n\t- - - Tryk ENTER for at afslutte! - - -");
            Console.ReadKey();
        }
    }
}
