using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojistenych
{
    internal class Databaze
    //správa kolekce pojištěnců//
    {
        public List<Pojistenec> pojistenci;
        public Databaze()
        {
            pojistenci = new List<Pojistenec>();
        }

        public void PridejPojistence(string Jmeno, string Prijmeni, int Vek, int TelCislo)
        {

            pojistenci.Add(new Pojistenec(Jmeno, Prijmeni, Vek, TelCislo));
        }
        
        public void VypisPojistence()
        {
            foreach (Pojistenec pojistenec in pojistenci)
                Console.WriteLine(pojistenec);
        }
        public void NajdiPojistence(string HledaneJmeno, string HledanePrijmeni)
        {
          foreach (Pojistenec pojistenec in pojistenci)
            {
                if ((HledaneJmeno == pojistenec.Jmeno) && (HledanePrijmeni == pojistenec.Prijmeni))
                    Console.WriteLine(pojistenec);
                else
                    Console.WriteLine("Zadané jméno není v evidenci");
            }
        }           
     }
 }
        
         
    

       
        
  
    

//}
