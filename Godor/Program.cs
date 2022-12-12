using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Godor
{
    class Program
    {
        static List<int> melysegek = new List<int>();
        static List<Arok> aroks = new List<Arok>();
        static int tavolsag;
        static int db = 0;
        static void Main(string[] args)
        {
            ElsoFeladat();
            MasodikFeladat();
            HarmadikFeladat();
            NegyedikFeladat();
            OtodikFeladat();

            Console.ReadKey();
        }

        private static void OtodikFeladat()
        {
            Console.WriteLine($"\n5. feladat\nA gödrök száma: {db}");
        }

        private static void NegyedikFeladat()
        {
            Console.WriteLine("\n4. feladat");

            using (StreamWriter ki = new StreamWriter("godrok.txt"))
            {
                for (int i = 0; i < melysegek.Count; i++)
                {
                    if (melysegek[i] != 0)
                    {
                        ki.Write($"{melysegek[i]} ");
                    }
                    else
                    {
                        if (i != 0 && melysegek[i - 1] != 0)
                        {
                            ki.WriteLine();
                            db++;
                        }
                    }
                } 
            }
        }

        private static void HarmadikFeladat()
        {
            Console.WriteLine("\n3. feladat");
            int masik = melysegek.Where(x => x == 0).ToList().Count;
            
            int darab = 0;
            for (int i = 0; i < melysegek.Count; i++)
            {
                if (melysegek[i] == 0)
                {
                    darab++;
                }
            }

            double szazalek = Math.Round((double) masik / melysegek.Count * 100, 2);

            Console.WriteLine($"Az értintetlen terület aránya {szazalek}%.");

        }

        private static void MasodikFeladat()
        {
            Console.WriteLine("\n2. feladat");
            Console.Write("Adjon meg egy távolságértéket: ");
            tavolsag = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine($"Ezen a helyen a felszín {melysegek[tavolsag]} méter mélyen van.");
        }

        private static void ElsoFeladat()
        {
            Console.WriteLine("1. feladat");

            using (StreamReader be = new StreamReader("melyseg.txt"))
            {
                while (!be.EndOfStream)
                {
                    melysegek.Add(Convert.ToInt32(be.ReadLine()));
                }
            }

            Console.WriteLine($"A fájl adatainak száma: {melysegek.Count}");
        }
    }
}
