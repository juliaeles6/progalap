using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace borcsop20
{
    internal class Program
    {
        static int n;
        static Adat[] bor;

        struct Adat
        {
            public int mennyiseg;
            public int ar;
        }

        static void beolvas()
        {
            string bemenet;
            string[] darabok;

            bemenet = Console.ReadLine();
            n = int.Parse(bemenet);

            bor = new Adat[n + 1];

            for(int i = 1; i <= n; ++i)
            {
                bemenet = Console.ReadLine();
                darabok = bemenet.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                bor[i].mennyiseg = int.Parse(darabok[0]);
                bor[i].ar = int.Parse(darabok[1]);
            }
        }

        static bool nemVoltMeg(int i)
        {
            int j;

            j = 1;
            while(j <= i - 1 && bor[i].ar != bor[j].ar)
            {
                j = j + 1;
            }

            return j > i - 1; 
        }

        static bool nagyobbMintElotte(int i)
        {
            int j;

            j = 1;
            while(j <= i - 1 && bor[j].mennyiseg < bor[i].mennyiseg)
            {
                j = j + 1;
            }

            return j > i - 1;
        }

        static void Main(string[] args)
        {
            beolvas();

            // a)
            int legkisebbTermelesuEv;
            int minert;

            legkisebbTermelesuEv = 1;
            minert = bor[1].mennyiseg;

            for(int i = 2; i <= n; ++i)
            {
                if (bor[i].mennyiseg < minert)
                {
                    legkisebbTermelesuEv = i;
                    minert = bor[i].mennyiseg;
                }
            }

            Console.WriteLine(legkisebbTermelesuEv);

            // b)
            bool van;
            int legnagyobbAr1000Felett;

            van = false;
            legnagyobbAr1000Felett = 0;
            for(int i = 1; i <= n; ++i)
            {
                if (bor[i].mennyiseg <= 1000)
                {

                }
                else if (bor[i].mennyiseg > 1000 && van)
                {
                    if (bor[i].ar > legnagyobbAr1000Felett)
                    {
                        legnagyobbAr1000Felett = bor[i].ar;
                    }
                }
                else if (bor[i].mennyiseg > 1000 && !van)
                {
                    legnagyobbAr1000Felett = bor[i].ar;
                    van = true;
                }
            }

            if(!van)
            {
                legnagyobbAr1000Felett = -1;
            }

            Console.WriteLine(legnagyobbAr1000Felett);

            int arakSzama;

            arakSzama = 0;
            for(int i = 1; i <= n; ++i)
            {
                if(nemVoltMeg(i))
                {
                    arakSzama = arakSzama + 1;
                }
            }

            Console.WriteLine(arakSzama);

            // d)

            int nagyobbMintElotteDb;
            List<int> nagyobbMintElotteIndexek = new List<int>();

            nagyobbMintElotteDb = 0;
            for(int i = 2; i <= n; ++i)
            {
                if(nagyobbMintElotte(i))
                {
                    nagyobbMintElotteDb = nagyobbMintElotteDb + 1;
                    nagyobbMintElotteIndexek.Add(i);
                }
            }

            Console.WriteLine(nagyobbMintElotteDb + " " + string.Join(" ", nagyobbMintElotteIndexek));
        }
    }
}
