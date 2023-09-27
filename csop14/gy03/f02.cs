namespace gy03f02
{
    public class Program
    { 
        public struct Ember
        {
            public string nev;
            public int kor;
            public string foglalkozas;
        }

        public static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Add meg a darabszamot");
            n = int.Parse(Console.ReadLine());

            while(n <= 0)
            {
                Console.WriteLine("Rossz szam!");
                Console.WriteLine("Add meg a darabszamot");
                n = int.Parse(Console.ReadLine());
            }

            Ember[] emberek = new Ember[n + 1];

            for(int i = 1; i <= n; ++i)
            {
                Console.WriteLine("Add meg a nevet, korat es foglalkozasat!");

                string[] sor = Console.ReadLine().Split();

                emberek[i].nev = sor[0];
                emberek[i].kor = int.Parse(sor[1]);
                emberek[i].foglalkozas = sor[2];

                while (emberek[i].kor <= 0)
                {
                    Console.WriteLine("Rossz adatok!");
                    Console.WriteLine("Add meg a nevet, korat es foglalkozasat!");

                    sor = Console.ReadLine().Split();
                    emberek[i].nev = sor[0];
                    emberek[i].kor = int.Parse(sor[1]);
                    emberek[i].foglalkozas = sor[2];
                }
            }

            int s;

            Console.WriteLine("Add meg a sorszamot");
            s = int.Parse(Console.ReadLine());

            while (s < 1 || s > n)
            {
                Console.WriteLine("Rossz szam!");
                Console.WriteLine("Add meg a sorszamot");
                s = int.Parse(Console.ReadLine());
            }

            string f;
            f = emberek[s].foglalkozas;

            Console.WriteLine("Foglalkozas: " + f);


        }
    }
}