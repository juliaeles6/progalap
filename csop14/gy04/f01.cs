using System;

namespace gy04f01 { internal class Program {
        static void Main(string[] args) {
            Console.Error.WriteLine("Kérek egy számot: "); // a standard hiba outputra ír. Ez, ha lokálisan futtatjátok, akkor megegyezik a standard outputtal, viszont a Mester és a Bíró nem vesz figyelembe

            string s = Console.ReadLine(); int n = int.Parse(s);

            int[] x = new int[n + 1];

            for(int i = 1; i <= n; ++i) {
                s = Console.ReadLine(); x[i] = int.Parse(s);
            }

            int eso;
            
            eso = 0; for (int i = 1; i <= n; ++i) {
                eso += x[i];
                // eso = eso + x[i]
            }

            Console.WriteLine(eso);
        }
    }
}
