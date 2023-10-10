namespace gy05f01
{
    internal class Program
    {
       
        struct Napsz
        {
            public int kezd, veg, ber;
        }

        static int m, n;
        static Napsz[] napsz;

        // ber : N -> N
        // ber(i) = (napsz[i].veg - napsz[i].kezd + 1) * napsz[i].ber
        static int ber(int i)
        {
            return (napsz[i].veg - napsz[i].kezd + 1) * napsz[i].ber;
        }


        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            m = int.Parse(s[0]);
            n = int.Parse(s[1]);

            napsz = new Napsz[n + 1];

            for (int i = 1; i <= n; ++i)
            {
                s = Console.ReadLine().Split();
                napsz[i].kezd = int.Parse(s[0]);
                napsz[i].veg = int.Parse(s[1]);
                napsz[i].ber = int.Parse(s[2]);
            }

            int osszBer;

            osszBer = 0;
            for(int i = 1; i <= n; ++i)
            {
                osszBer += ber(i);
            }

            int maxind, maxert;
            maxert = ber(1);
            maxind = 1;

            for(int i = 2; i <= n; ++i)
            {
                if(ber(i) > maxert)
                {
                    maxert = ber(i);
                    maxind = i;
                }
            }

            Console.WriteLine(osszBer);
            Console.WriteLine(maxind);
        }
    }
}