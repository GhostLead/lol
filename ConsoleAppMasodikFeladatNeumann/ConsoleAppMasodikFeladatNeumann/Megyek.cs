using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMasodikFeladatNeumann
{
    internal class Megyek
    {
        string kod;
        string nev;

        public Megyek(string sor)
        {
            string[] tomb = sor.Split("\t");
            this.Kod = tomb[0];
            this.Nev = tomb[1];
        }

        public string Kod { get => kod; set => kod = value; }
        public string Nev { get => nev; set => nev = value; }
    }
}
