using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Godor
{
    class Arok
    {
        public int Hosszusag { 
            get 
            {
                return Vege - Kezdete;
            }
        }
        public int Kezdete { get; set; }
        public int Vege { get; set; }

        List<int> melysegek = new List<int>();

        public int Max { get { return melysegek.Max(); } }

        public int Terfogat {
            get
            {
                return melysegek.Sum() * SZELESSEG;
            }
        }

        const int SZELESSEG = 10;

        public Arok(int kezdete, int vege, List<int> melysegek)
        {
            Kezdete = kezdete;
            Vege = vege;
            foreach (var item in melysegek)
            {
                this.melysegek.Add(item);
            }
        }
    }
}
