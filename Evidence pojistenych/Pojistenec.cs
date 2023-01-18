using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojistenych
{
    internal class Pojistenec      
        
    {
        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }   
        private int Vek { get; set; }
        private int TelCislo { get; set; }
        public Pojistenec (string Jmeno, string Prijmeni, int Vek, int TelCislo)
        {
            this.Jmeno = Jmeno;
            this.Prijmeni = Prijmeni;
            this.Vek = Vek;
            this.TelCislo = TelCislo;
        }
        public override string ToString()
        {
           return Jmeno + "\t" + Prijmeni + "\t" + Vek + "\t" + TelCislo;
        }    
    }
}
