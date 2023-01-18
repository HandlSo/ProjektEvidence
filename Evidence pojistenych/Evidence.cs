using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojistenych
{
    internal class Evidence
    //metody pro komunikaci s uživatelem//
    {
        Databaze databaze;
        public Evidence()
        {
            databaze = new Databaze();
        }
        public void ZadejPojistence()
        {
            int TelCislo;
            Console.WriteLine("\nZadejte jméno pojištěného: ");
            string Jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení pojištěného: ");
            string Prijmeni = Console.ReadLine();
            Console.WriteLine("Zadejte tel. číslo pojištěného: ");
            while (!int.TryParse(Console.ReadLine(),out TelCislo))
            { 
                Console.WriteLine("neplatný formát");
            }
            Console.WriteLine("Zadejte věk: ");
            int Vek = int.Parse(Console.ReadLine());
            databaze.PridejPojistence(Jmeno, Prijmeni, TelCislo, Vek);
            Console.WriteLine("\nData byla uložena, pokračujte libovolnou klávesou...");
        }
        public void VypisPojistence()
        {
            databaze.VypisPojistence();
        }
        public void VyhledejPojistence()
        {
            Console.WriteLine("\nZadejte jméno pojištěného: ");
            string HledaneJmeno = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení pojištěného: ");
            string HledanePrijmeni = Console.ReadLine();
            databaze.NajdiPojistence(HledaneJmeno, HledanePrijmeni);
        }
    }
}
