using System;
using System.Collections.Generic;

namespace mintaZH1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n;

            n = int.Parse(s);

            int[] minh = new int[n + 1];
            int[] maxh = new int[n + 1];

            for(int i = 1; i <= n; ++i)
            {
                string[] sor = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                minh[i] = int.Parse(sor[0]);
                maxh[i] = int.Parse(sor[1]);
            }

            Console.WriteLine("#");

            int db = 0;
            for(int i = 1; i <= n; ++i)
            {
                if (minh[i] <= 0)
                {
                    ++db;
                }
            }

            Console.WriteLine(db);

            Console.WriteLine("#");

            int maxind = 1;
            int maxert = maxh[1] - minh[1];

            for(int i = 2; i <= n; ++i)
            {
                if (maxert < maxh[i] - minh[i])
                {
                    maxert = maxh[i] - minh[i];
                    maxind = i;
                }
            }

            Console.WriteLine(maxind);

            Console.WriteLine("#");

            bool van = false;
            int ind = 2;

            while(!van && ind <= n)
            {
                if (maxh[ind] < minh[ind - 1])
                {
                    van = true;
                }
                else
                {
                    ind++;
                }
            }

            if(van)
            {
                Console.WriteLine(ind);
            }
            else
            {
                Console.WriteLine(-1);
            }

            Console.WriteLine("#");

            int ddb = 0;
            List<int> y = new List<int>();

            for(int i = 1; i <= n; ++i)
            {
                if (minh[i] <= 0 && maxh[i] > 0)
                {
                    ++ddb;
                    y.Add(i);
                }
            }

            Console.Write(ddb + " " + string.Join(' ', y));
        }

    }
}