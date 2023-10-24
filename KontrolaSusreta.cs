using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace NogometniSusret
{
    internal class KontrolaSusreta
    {
       
        public Susret EvidentirajSusret(string domacinOznaka, string gostOznaka, string rezultat)
        {
           
                var rezSplited = SplitRezultat(rezultat);
                return new Susret(
                    new Repozitorij().DohvatiReprezentaciju(domacinOznaka),
                    new Repozitorij().DohvatiReprezentaciju(gostOznaka),
                    int.Parse(rezSplited[0]),
                    int.Parse(rezSplited[1])
                    );
           
        }

        private string[] SplitRezultat(string rezultat)
        {
            return rezultat.Split(":");
           
        }
    }
}
