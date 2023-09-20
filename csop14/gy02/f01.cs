namespace feladat01 {
    internal class Program {
        static void Main(string[] args) {
            int a, b;
            Console.Write("Adj meg két számot: ");
            string[] s = Console.ReadLine().Split();

            a = int.Parse(s[0]);
            b = int.Parse(s[1]);

            while(!(a > 0 && b > 0))
            {
                Console.WriteLine("Pozitív számokat adj meg!");
                Console.Write("Adj meg két számot: ");
                s = Console.ReadLine().Split();
                
                a = int.Parse(s[0]);
                b = int.Parse(s[1]);    
            }


            int d;

            while (a != b)
            {
                if(a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }

            d = a;

            Console.WriteLine("A két szám legnagyobb közös osztója: ");
            Console.WriteLine(d);
        }
    }
}
