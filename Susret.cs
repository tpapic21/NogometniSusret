using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NogometniSusret
{
    internal class Susret
    {
        public Reprezentacija Domacin { get; set; }
        public Reprezentacija Gost { get; set; }
        public int BrojPogodakaDomacin { get; set; }
        public int BrojPogodakaGost { get; set; }

        public Susret(Reprezentacija reprezentacijaDomacin, Reprezentacija reprezentacijaGost, int brojPogodakaDomacin, int brojPogodakaGost)
        {
            Domacin = reprezentacijaDomacin;
            Gost = reprezentacijaGost;
            BrojPogodakaDomacin = brojPogodakaDomacin;
            BrojPogodakaGost = brojPogodakaGost;
        }
    }
}
