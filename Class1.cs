using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Produkt
    {
        public string Nazwa { get; set; }
        public int Cena { get; set; }
        public string Opis { get; set; }
        public Produkt(string nazwa, int cena, string opis)
        {
            Nazwa = nazwa;
            Cena = cena;
            Opis = opis;
        }
    }
}
