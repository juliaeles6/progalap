namespace feladat04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Kérjük add meg n értékét (n >= 3): ");
            string s = Console.ReadLine();

            n = int.Parse(s);

            while(n < 3)
            {
                Console.WriteLine("A szám legyen legalább 3!");
                Console.Write("Kérjük add meg n értékét (n >= 3): ");
                s = Console.ReadLine();

                n = int.Parse(s);
            }

            int e;
            int m = 0;
            int[] x = new int[n + 1];

            for (e = 0; e <= n; e++) 
            {
                if(e % 2 == 0)
                {
                    m++;
                    x[m] = e;
                }
            }

            Console.WriteLine("A páros számok 0 és n között:");
            for(int i = 1; i <= m; i++)
            {
                Console.Write(x[i] + " ");
            }

        }
    }
}
