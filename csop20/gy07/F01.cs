using System;
using System.Collections.Generic;

namespace kutyiversenycsop25
{
    internal class Program
    {
        static int n, m;
        static int[] minp, maxp;
        static int[,] p;

        static void beolvas()
        {
            string bemenet;
            string[] darabok;

            bemenet = Console.ReadLine();
            darabok = bemenet.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            n = int.Parse(darabok[0]);
            m = int.Parse(darabok[1]);

            minp = new int[m + 1];
            maxp = new int[m + 1];
            p = new int[n + 1, m + 1];

            bemenet = Console.ReadLine();
            darabok = bemenet.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for(int i = 1; i <= m; ++i)
            {
                maxp[i] = int.Parse(darabok[i - 1]);
            }

            bemenet = Console.ReadLine();
            darabok = bemenet.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 1; i <= m; ++i)
            {
                minp[i] = int.Parse(darabok[i - 1]);
            }

            for(int i = 1; i <= n; ++i)
            {
                bemenet = Console.ReadLine();
                darabok = bemenet.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for(int j = 1; j <= m; ++j)
                {
                    p[i, j] = int.Parse(darabok[j - 1]);
                }
            }
        }

        static bool kiesett(int i)
        {
            int j;
            j = 1;
            while(j <= m && p[i, j] >= minp[j])
            {
                ++j;
            }

            return j <= m;
        }

        static int pontszam(int i)
        {
            int s;
            s = 0;

            for(int j = 1; j <= m; ++j)
            {
                s = s + p[i, j];
            }

            return s;
        }

        static void Main(string[] args)
        {
            beolvas();
            int db;
            List<int> osszpont = new List<int>();

            db = 0;
            for(int i = 1; i <= n; ++i)
            {
                if(kiesett(i))
                {
                    ++db;
                    osszpont.Add(pontszam(i));
                }
            }

            Console.WriteLine(db + " " + string.Join(" ", osszpont));
        }
    }
}
