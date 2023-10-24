using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NogometniSusret
{
    internal class Repozitorij
    {
         private List<Reprezentacija> reprezentacija = new()
        {
            new Reprezentacija("HRV","Hrvatska"),
            new Reprezentacija("GER","Njemačka"),
            new Reprezentacija("FRA","Francuska")
        };

        public Reprezentacija DohvatiReprezentaciju(string oznaka)
        {
            
            return reprezentacija.Where(p=>p.Oznaka==oznaka).FirstOrDefault() ?? throw new Exception("Nepoznata reprezentacija");
        }

       
    }
}
