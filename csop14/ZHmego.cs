// Nev: Minta Janos
// Neptun: MINTA1

namespace mintaZH {
    internal class mintaZH {
        struct Lako {
            public string nev;
            public int kor;
            public int baratok;
            public string foglalkozas;
        };
        static Lako[] lakok;
        static int n;

        static bool nemVoltMeg(int ind) {
            bool van;
            int j;

            van = false;
            j = 1;

            while(!van && j <= ind - 1) {
                if (lakok[j].foglalkozas == lakok[ind].foglalkozas) {
                    van = true;
                }
                else {
                    j++;
                }
            }

            return !van;
        }

        static void Main(string[] args) {
            string sor;
            string[] reszek;
            int i;

            // beolvasas:
            Console.WriteLine("Add meg a darabszamot (1 es 10000 kozotti egesz)");

            sor = Console.ReadLine();
            n = int.Parse(sor);
            
            while(n < 1 || 10_000 < n) {
                Console.WriteLine("Rossz erteket adtal meg!");
                Console.WriteLine("Add meg a darabszamot (1 es 10000 kozotti egesz)");

                sor = Console.ReadLine();
                n = int.Parse(sor);
            }

            lakok = new Lako[n + 1];

            for (i = 1; i <= n; ++i) {
                Console.WriteLine("Add meg szokozzel elvalasztva a kovetkezo adatokat: nev, kor (1 es 100 kozotti egesz), baratok szama (legalabb 0, maximum a darabszam - 1) es foglalkozas");

                reszek = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                
                int kor = int.Parse(reszek[1]);
                int baratDb = int.Parse(reszek[2]);

                while((kor < 0 || 100 < kor) || (baratDb < 0 || n - 1 < baratDb)) {
                    Console.WriteLine("Rossz erteket adtal meg!");
                    Console.WriteLine("Add meg szokozzel elvalasztva a kovetkezo adatokat: nev, kor (1 es 100 kozotti egesz), baratok szama (legalabb 0, maximum a darabszam - 1) es foglalkozas");

                    reszek = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    kor = int.Parse(reszek[1]);
                    baratDb = int.Parse(reszek[2]);
                }

                lakok[i].nev = reszek[0];
                lakok[i].kor = kor;
                lakok[i].baratok = baratDb;
                lakok[i].foglalkozas = reszek[3];
            }

            // megoldas:

            int foglalkozasDb;

            foglalkozasDb = 0;

            for(i = 1; i <= n; ++i) {
                if(nemVoltMeg(i)) {
                    foglalkozasDb++;
                }
            }

            bool van;

            van = false;
            i = 1;

            while(!van && i <= n) {
                if (lakok[i].kor < lakok[i].baratok) {
                    van = true;
                }
                else {
                    ++i;
                }
            }

            // kiiras:

            Console.WriteLine("A foglalkozasok szama: " + foglalkozasDb);
            if(van) {
                Console.WriteLine("Van olyan ember, akinek tobb baratja van, mint ahany eves");
            }
            else {
                Console.WriteLine("Nincs olyan ember, akinek tobb baratja van, mint ahany eves");
            }

        }
    }
}
