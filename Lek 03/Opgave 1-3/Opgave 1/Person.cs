using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_1
{
    class Person
    {
        public Person(string navn, string adresse)
        {
            Navn = navn;
            Adresse = adresse;
        }

        public string Navn { get; set; }
        public string Adresse { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"[Person]" +
                $"\nNavn: {Navn}" +
                $"\nAdresse: {Adresse}");
        }
    }
}
