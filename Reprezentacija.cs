﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NogometniSusret
{
    internal class Reprezentacija
    {
        public string Oznaka { get; set; }
        public string Naziv { get; set; }

        public Reprezentacija(string oznaka, string naziv) 
        {
            Oznaka=oznaka; 
            Naziv=naziv;
        }
    }
}
