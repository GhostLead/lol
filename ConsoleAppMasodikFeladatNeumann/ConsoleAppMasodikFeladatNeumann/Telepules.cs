using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMasodikFeladatNeumann
{
    internal class Telepules
    {
        string iranyitoszam;
        string megyeazonosito;
        double szelesseg;
        double hosszusag;
        double terulet;
        int lakosokszama;
        string telepulesnev;
        int tavolsagkecskemettol;
        int tavolsagszegedtol;

        public Telepules(string sor)
        {
            string[] tomb = sor.Split();

            this.Iranyitoszam = tomb[0];
            this.MegyeAzonosito = tomb[1];
            this.Szelesseg = Convert.ToDouble(tomb[2].Replace('.',','));
            this.Hosszusag = Convert.ToDouble(tomb[3].Replace('.', ','));
            this.Terulet = Convert.ToDouble(tomb[4].Replace('.', ','));
            this.LakosokSzama = Convert.ToInt32(tomb[5]);
            this.TelepulesNev = tomb[6];
            this.TavolsagKecskemettol = Convert.ToInt32(tomb[7]);
            this.TavolsagSzegedtol = Convert.ToInt32(tomb[8]);
        }

        public string Iranyitoszam { get => iranyitoszam; set => iranyitoszam = value; }
        public string MegyeAzonosito { get => megyeazonosito; set => megyeazonosito = value; }
        public double Szelesseg { get => szelesseg; set => szelesseg = value; }
        public double Hosszusag { get => hosszusag; set => hosszusag = value; }
        public double Terulet { get => terulet; set => terulet = value; }
        public int LakosokSzama { get => lakosokszama; set => lakosokszama = value; }
        public string TelepulesNev { get => telepulesnev; set => telepulesnev = value; }
        public int TavolsagKecskemettol { get => tavolsagkecskemettol; set => tavolsagkecskemettol = value; }
        public int TavolsagSzegedtol { get => tavolsagszegedtol; set => tavolsagszegedtol = value; }
    }
}
