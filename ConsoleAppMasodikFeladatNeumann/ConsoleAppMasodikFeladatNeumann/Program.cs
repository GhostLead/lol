using System.Security.Principal;

namespace ConsoleAppMasodikFeladatNeumann
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Telepules> telepulesek = File.ReadAllLines("telepules.txt").Select(x => new Telepules(x)).ToList();
            List<Megyek> megyek = File.ReadAllLines("megyek.txt").Select(x => new Megyek(x)).ToList();
            Dictionary<string,int> megyeklakosai = new Dictionary<string,int>();

            // 2a)
            List<Telepules> telepulesekRendezve = telepulesek.OrderBy(x => x.LakosokSzama).ToList();
            telepulesekRendezve.RemoveAt(0);
            string megyenev = megyek.Find(x => x.Kod == telepulesekRendezve[0].MegyeAzonosito).Nev;
            foreach (var telepules in telepulesek)
            {
                if (megyeklakosai.ContainsKey(megyek.Find(x => x.Kod == telepules.MegyeAzonosito).Nev))
                {
                    continue;
                }
                else
                {
                    megyeklakosai.Add(megyek.Find(x => x.Kod == telepules.MegyeAzonosito).Nev, 0);
                }
                
            }
            int lakosszam = 0;
            foreach (var item in megyeklakosai)
            {
                foreach (var telepules in telepulesek)
                {
                    if (megyek.Find(x => x.Kod == telepules.MegyeAzonosito).Nev == item.Key)
                    {
                        megyeklakosai[megyek.Find(x => x.Kod == telepules.MegyeAzonosito).Nev] += telepules.LakosokSzama;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            megyeklakosai.Remove(megyeklakosai.Keys.First());
            Console.WriteLine($"{megyeklakosai.OrderBy(x => x.Value).First().Key}-{megyeklakosai.OrderBy(x => x.Value).First().Value}");

            //Console.WriteLine($"{megyenev}-{telepulesekRendezve.First().LakosokSzama}");

            // 2b)
            

        }
    }
}