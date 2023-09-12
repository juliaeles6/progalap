namespace feladat01 {
    internal class Program {
        static void Main(string[] args) {
            string s;
            s = Console.ReadLine(); 
            int a;
            a = int.Parse(s);

            if (a <= 0) {
                return;
            }

            int b;
            b = a;
            Console.WriteLine(b);

        }
    }
}