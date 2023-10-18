using System;
using System.Collections.Generic;

namespace f02 {
    internal class Program {
        static void Main(string[] args) {
            string[] s = Console.ReadLine().Split();

            int n, k;
            n = int.Parse(s[0]);
            k = int.Parse(s[1]);

            int[] ter = new int[n + 1];
            int[] ar = new int[n + 1];
            for (int i = 1; i <= n; ++i)  {
                s = Console.ReadLine().Split();
                ter[i] = int.Parse(s[0]);
                ar[i] = int.Parse(s[1]);
            }

            int db;

            List<int> draga = new List<int>(); 
            db = 0;

            for(int i = 1; i <= n; ++i) {
                if (ar[i] > k) {
                    db++;
                    draga.Add(i);
                }
            }

            Console.Write(db + " ");
            for(int i = 0; i < db; ++i) {
                Console.Write(draga[i] + " ");
            }
        }
    }
}
