using System;
using System.Security.Cryptography.X509Certificates;

namespace EvidencePojistenych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instance Evidence//
            Evidence evidence = new Evidence();
            char volba = '0';
            //Hlavní cyklus//
            while (volba != 4)
            {
                Console.WriteLine("EVIDENCE POJIŠTĚNÝCH");
                Console.WriteLine("Vyberte akci: ");
                Console.WriteLine("1 - Přidat nového pojištěnce");
                Console.WriteLine("2 - Vypsat všechny pojištěné");
                Console.WriteLine("3 - Vyhledat pojištěného");
                Console.WriteLine("4 - Konec");
                volba = Console.ReadKey().KeyChar;
                switch (volba)
                {
                    case '1':
                        evidence.ZadejPojistence();
                        break;        
                    case '2':
                        evidence.VypisPojistence();
                        break;
                    case '3':
                        evidence.VyhledejPojistence();
                        break;
                    case '4':
                        Console.WriteLine("Libovolnou klávesou ukončíš program");
                        break;
                    default:
                        Console.WriteLine("Neplatná volba, stiskni libovolnou klávesu a opakuj akci");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}


