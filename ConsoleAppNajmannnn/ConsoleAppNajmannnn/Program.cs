using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleAppNajmannnn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Szamok = File.ReadAllLines("szamok.txt").ToList();

            // 1c)

            List<int> ketjegyuek = new List<int>();

            foreach (string szam in Szamok)
            {
                for (int i = 0; i < szam.Length-1; i++)
                {
                    try
                    {
                        ketjegyuek.Add(Convert.ToInt32($"{szam[i]}{szam[i + 1]}"));
                    }
                    catch (IndexOutOfRangeException)
                    {
                        continue;
                    }
                }
            }

            int megoldas = ketjegyuek.GroupBy(x => x).OrderByDescending(group => group.Count()).Select(group => group.Key).First();
            Console.WriteLine(megoldas);

        }
    }
}