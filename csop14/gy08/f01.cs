// Mester / középhaladó / verseny / 19

namespace feladat01 {
    internal class Program {
        struct Verseny {
            public int db;
            public int[] sorszam;
            public int[] pontszam;
        };

        static int n, m;
        static Verseny[] versenyek;

        static bool jo(int i) {
            bool van;
            int j;

            van = false;
            j = 1;

            while (!van && j <= m) {
                if (resztvett(i, j) && nemnyerte(i, j)) {
                    van = true;
                }
                else {
                    ++j;
                }
            }

            return van;
        }

        static bool resztvett(int i, int j) {
            bool van;
            int k;

            van = false;
            k = 1;

            while (!van && k <= versenyek[j].db) {
                if (versenyek[j].sorszam[k] == i) {
                    van = true;
                }
                else {
                    ++k;
                }
            }

            return van;
        }

        static bool nemnyerte(int i, int j) {
            int maxert;
            int k;

            maxert = versenyek[j].pontszam[1];

            for (k = 2; k <= versenyek[j].db; ++k) {
                if (maxert < versenyek[j].pontszam[k]) {
                    maxert = versenyek[j].pontszam[k];
                }
            }

            bool van;
            van = false;
            k = 1;

            while (!van && k <= versenyek[j].db) {
                if (versenyek[j].sorszam[k] == i && versenyek[j].pontszam[k] == maxert) {
                    van = true;
                }
                else {
                    ++k;
                }
            }

            return van;
        }

        static void Main(string[] args) {
            string be = Console.ReadLine();
            string[] sor = be.Split();

            n = int.Parse(sor[0]);
            m = int.Parse(sor[1]);

            int[] x = new int[m + 1];

            be = Console.ReadLine();

            sor = be.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries); // előző órán így csináltuk
            sor = be.Split().Where(s => s.Length > 0).ToArray(); // LINQ (Language INtegrated Queries) függvenyekkel
            // SQL stílusú, progmintákat is lehet LINQ függvényekkel írni (de nem a csoportos ZH-n :)). Ha ezt használjuk Mesteres/Bírós feladatmegoldásra, akkor felülre az using System.Linq; sort kell írni
            // bővebben LINQ függvényekről: https://learn.microsoft.com/en-us/dotnet/csharp/linq/

            //előző órán
            for (int i = 1; i <= m; ++i) {
                x[i] = int.Parse(sor[i - 1]);
            }

            // x = Array.ConvertAll(sor, int.Parse); 
            // Mint a Haskellben a map függvény, vigyázni kell az idexeléssel

            versenyek = new Verseny[m + 1];

            for (int i = 1; i <= m; ++i) {
                be = Console.ReadLine();
                sor = be.Split().Where(s => s.Length > 0).ToArray();
                int[] egeszek = Array.ConvertAll(sor, int.Parse);

                versenyek[i].db = egeszek[0];
                versenyek[i].sorszam = new int[versenyek[i].db + 1];
                versenyek[i].pontszam = new int[versenyek[i].db + 1];

                for (int j = 1; j < egeszek.Length; j += 2) {
                    versenyek[i].sorszam[(j + 1) / 2] = egeszek[j];
                    versenyek[i].pontszam[(j + 1) / 2] = egeszek[j + 1];
                }
            }

            int db = 0;
            List<int> y = new List<int>();

            for (int i = 1; i <= n; ++i) {
                if (jo(i)) {
                    y.Add(i);
                    ++db;
                }
            }

            // ami pedig órán nem jutott eszembe, hogy pontosan hogy van: egy sorban egy tömb kiírása
            // a string.Join függvény első paramétere az a string, amivel össze akarod kötni a második paraméterben adott tömb/lista elemeit (az utolsó után nem teszi ki az elválasztójelet)

            Console.WriteLine(string.Join(' ', y));
        }
    }
}