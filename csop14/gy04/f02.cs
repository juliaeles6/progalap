using System;
using System.ComponentModel;

namespace gy04f02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            int n = int.Parse(s);

            int[] k = new int[n + 1];

            for(int i = 1; i <= n; ++i)
            {
                s = Console.ReadLine();
                k[i] = int.Parse(s);
            }

            int db;

            db = 0;

            for(int i = 1; i <= n; ++i)
            {
                if (k[i] > 0)
                {
                    db++;
                }
            }

            Console.WriteLine(db);
        }
    }
}