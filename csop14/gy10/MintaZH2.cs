using System;

namespace mintaZH2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            string s = Console.ReadLine();

            n = int.Parse(s);

            int[] kor = new int[n + 1];
            int[] fizu = new int[n + 1];

            for(int i = 1; i <= n; ++i)
            {
                string[] sor = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                kor[i] = int.Parse(sor[0]);
                fizu[i] = int.Parse(sor[1]);
            }

            int maxert = kor[1];
            int maxind = 1;

            for(int i = 2; i <= n; ++i)
            {
                if(maxert < kor[i])
                {
                    maxert = kor[i];
                    maxind = i;
                }
            }

            Console.WriteLine(maxind);

            int db = 0;
            for(int i = 1; i <= n; ++i)
            {
                if (kor[i] > 40 && fizu[i] < 200_000)
                {
                    ++db;
                }
            }

            Console.WriteLine(db);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}