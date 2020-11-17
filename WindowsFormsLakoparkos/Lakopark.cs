using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLakoparkos
{
    class Lakopark
    {
        private string nev;
        private int utcakSzama;
        private int maxHazSzam;
        private int[,] hazak;

        public Lakopark(string nev, int utcak, int hazakSzama, int[,] hazAdat)
        {
            this.nev = nev;
            this.utcakSzama = utcak;
            this.maxHazSzam = hazakSzama;
            this.hazak = hazAdat;
        }

        public string Nev { get => nev;}
        public int UtcakSzama { get => utcakSzama;}
        public int MaxHazSzam { get => maxHazSzam;}
        public int[,] Hazak { get => hazak;}

        public double beepitettseg()
        {
            int beepitett = 0;
            for (int i = 0; i < utcakSzama; i++)
            {
                for (int j = 0; j < maxHazSzam; j++)
                {
                    if (hazak[i, j] > 0)
                    {
                        beepitett++;
                    }
                }
            }
            
            return (double)beepitett/(maxHazSzam*utcakSzama);
        }
    }
}
